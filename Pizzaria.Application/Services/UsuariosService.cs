using Pizzaria.Application.DTOs;
using Pizzaria.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaria.Application.Services
{
    internal class UsuariosService : IUsuariosService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private UsuariosService(UserManager<Identity> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var users = _userManager.Users.ToList();
            var result = new List<UsuarioDto>();

            foreach(var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                result.Add(new UsuarioDto
                {
                    Id = user.Id,
                    Name = user.UserName ?? string.Empty,
                    Email = user.Email ?? string.Empty,
                    Role = roles.FirstOrDefault() ?? "Usuario"
                });
            }
            return result;
        }
        
        public async Task<UsuarioDto>GetByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return null;
            var roles = await _userManager.GetRolesAsync(user);
            return new UsuarioDto
            {
                Id = user.Id,
                Name = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                Role = user.Roles.FirstOrDefault() ?? "Usuario"
            };
        }

        public async Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> CreateAsync(CreateUsuarioDto dto)
        {
            if (dto.Password != dto.ConfirmPassword)
                return (false, null, "As senhas não coincidem");

            var existingUser = await _userManager.FindByIdAsync(dto.Email);
            if (existingUser != null) return (false, null, "E-mail já cadastrado");

            var user = new IdentityUser
            {
                UserName = dto.Name,
                Email = dto.Email
            };
            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return (false, null, $"Erro ao criar usuário: {errors}");
            }

            if (!string.IsNullOrWhiteSpace(dto.Role))
            {
                if (await _roleManager.RoleExistsAsync(dto.Role))
                {
                    await _userManager.AddToRoleAsync(user, dto.Role);
                }
            }
            else
            {
                await _userManager.AddToRoleAsync(user, "Usuario");
            }
            var createdUser = await GetByIdAsync(user.Id);
            return (true, createdUser, string.Empty);
        }

        public async Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> UpdateAsync(string id, UpdateCategoryDto dto)
        {
            if (!string.IsNullOrWhiteSpace(dto.Password) && dto.Password != dto.ConfirmPassword)
                return (false, null, "As senhas não coincidem.");

            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return (false, null, "E-mail ja cadastrado por outro usuario.");

            user.UserName = dto.Name;
            user.Email = dto.Email;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeded)
            {
                var errors = string.Join(", ", updateResult.Errors.Select(e => e.Description));
                return (false, null, $"Erro ao atualizar usuário: {errors}");
            }

            if (!string.IsNullOrWhiteSpace(dto.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var passResult = await _userManager.ResetPasswordAsync(user, token, dto.Senha);
                if (!passResult.Succeeded)
                {
                    var errors = string.Join(", ", passResult.Errors.Select(e => e.Description));
                    return (false, null, $"Erro ao atualizar senha: {errors}");
                }
            }

            var currentRoles = await _userManager.GetRolesAsync(user);
            if (!string.IsNullOrWhiteSpace(dto.Role)) && !currentRoles.Contains(dto.Roles)
            {
                if (await _roleManager.RoleExistsAsync(dto.Perfil))
                {
                    await _userManager.RemoveFromRolesAsync(user, currentRoles);
                    await _userManager.AddToRoleAsync(user, dto.Roles);
                }
            }
            var updatedUser = await GetByIdAsync(user.Id);
            return (true, updatedUser, string.Empty);
        }
        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return (false, "Usuário não encontrado");

            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return (false, $"Erro ao excluir usuário: {errors}");
            }
            return (true, string.Empty);
        }

        public async Task<IEnumerable<string>> GetPerfilAsync()
        {
            var roles = _roleManager.Roles.Select(r => r.Name).ToList();
            return await Task.FromResult(roles!);
        }
    }
}
