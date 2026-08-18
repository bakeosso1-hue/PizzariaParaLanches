using Pizzaria.Desktop.DTOs;
using Pizzaria.Desktop.Helpers;


namespace Pizzaria.Desktop.Services
{
    public class UsuariosApiService
    {
        private readonly HttpClientHelper _http;

        public UsuariosApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        public async Task<List<UsuarioResponseDto>> GetAllAsync()
        {
            try
            {
                var usuarios = await _http.GetAsync<List<UsuarioResponseDto>>("/api/users");
                return usuarios ?? new List<UsuarioResponseDto>();
            }
            catch
            {
                return new List<UsuarioResponseDto>();
            }
        }

        public async Task<(bool Success, UsuarioResponseDto? Usuario, string ErrorMessage)>
            CreateAsync(CreateUsuarioDto dto)
        {
            return await _http.PostAsync<UsuarioResponseDto>("/api/users", dto);
        }

        public async Task<(bool Success, string ErrorMessage)> DeleteAsync(string userId)
        {
            return await _http.DeleteAsync($"/api/users/{userId}");
        }

        public async Task<(bool Success, string ErrorMessage)> ResetPasswordAsync(
            ResetPasswordDto dto)
        {
            var (success, _, error) = await _http.PostAsync<object>(
                $"/api/users/{dto.UserId}/reset-password", dto);
            return (success, error);
        }

        public async Task<(bool Success, string ErrorMessage)> AssignRoleAsync(AssignRoleDto dto)
        {
            var (success, _, error) = await _http.PostAsync<object>(
                $"/api/users/{dto.UserId}/roles", dto);
            return (success, error);
        }
    }
}

