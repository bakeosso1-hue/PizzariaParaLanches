

using Pizzaria.Desktop.Helpers;
using Pizzaria.Desktop.DTOs;


namespace Pizzaria.Desktop.Services
{
    public class AuthApiService
    {
        private readonly HttpClientHelper _http;

        public AuthApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        public async Task<(bool Sucesso, UsuarioResponseDto? User, string ErrorMessage)> LoginAsync(string email, string password)
        {
            var loginDto = new LoginRequestDto
            {
                Email = email,
                Password = password
            };

            var (sucesso, data, error) = await _http.PostAsync<UsuarioResponseDto>(
                "/api/auth/login", loginDto);

            return (sucesso, data, error);
        }

        public async Task<(bool Sucesso, string ErrorMessage)> LogoutAsync()
        {
            var result = await _http.PostEmptyAsync("/api/auth/logout");

            _http.ClearCookies();

            return result;
        }

        public async Task<UsuarioResponseDto?> GetCurrentUserAsync()
        {
            return await _http.GetAsync<UsuarioResponseDto>("/api/auth/me");
        }

        public async Task<(bool Sucesso, string ErrorMessage)> RegisterAsync(
            string email, string password, string confirmPassword)
        {
            var dto = new RegisterRequestDto
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var (success, _, error) = await _http.PostAsync<object>("/api/auth/register", dto);
            return (success, error);
        }
    }
}
