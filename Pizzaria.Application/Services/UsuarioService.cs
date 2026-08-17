using Microsoft.AspNetCore.Identity;
using Pizzaria.Application.DTOs;
using Pizzaria.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria.Application.Services
{
    public class UsuarioService : IUsuariosService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsuarioService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<UsuarioDto>> GetAllAsync()
        {
            var users = _userManager.Users.ToList();
            var result = new List<UsuarioDto>();
            foreach (var user in users)
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

        public async Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> CreateAsync(CreateUsuarioDto dto)
        {
            if (dto.Password != dto.ConfirmPassword) return (false, null, "As senhas não coincidem");
            var user = new IdentityUser { UserName = dto.Name, Email = dto.Email };
            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded) return (false, null, "Erro ao criar usuario");

            await _userManager.AddToRoleAsync(user, dto.Role);

            var createdUser = new UsuarioDto { Id = user.Id, Name = user.UserName, Email = user.Email, Role = dto.Role };
            return (true, createdUser, string.Empty);
        }

        public async Task<(bool Success, UsuarioDto? Usuario, string ErrorMessage)> UpdateAsync(string id, UpdateUsuarioDto dto)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return (false, null, "Usuário não encontrado");
            user.UserName = dto.Name;
            user.Email = dto.Email;
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded) return (false, null, "Erro ao atualizar usuário");
            if (!string.IsNullOrEmpty(dto.Password))
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var passwordResult = await _userManager.ResetPasswordAsync(user, token, dto.Password);
                if (!passwordResult.Succeeded) return (false, null, "Erro ao atualizar senha");
            }
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.FirstOrDefault() != dto.Roles)
            {
                await _userManager.RemoveFromRolesAsync(user, roles);
                await _userManager.AddToRoleAsync(user, dto.Roles);
            }
            var updatedUser = new UsuarioDto { Id = user.Id, Name = user.UserName, Email = user.Email, Role = dto.Roles };
            return (true, updatedUser, string.Empty);
        }

        public async Task<UsuarioDto?> GetByIdAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return null;
            var roles = await _userManager.GetRolesAsync(user);
            return new UsuarioDto
            {
                Id = user.Id,
                Name = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                Role = roles.FirstOrDefault() ?? "Usuario"
            };
        }

        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return (false, "Usuário não encontrado");
            var result = await _userManager.DeleteAsync(user);
            if (!result.Succeeded) return (false, "Erro ao deletar usuário");
            return (true, string.Empty);
        }
        public async Task<IEnumerable<string>> GetPerfisAsync()
        {
            return _roleManager.Roles.Select(r => r.Name ?? string.Empty).ToList();
        }
    }
}
