using Movies.Desktop.DTOs;
using Movies.Desktop.Helpers;

namespace Movies.Desktop.Services
{
    /// <summary>
    /// Serviço responsável pela autenticação do usuário.
    /// </summary>
    public class AuthApiService
    {
        private readonly HttpClientHelper _http;

        /// <summary>
        /// Obtém o HttpClientHelper.
        /// </summary>
        public AuthApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        /// <summary>
        /// Realiza o login do usuário.
        /// </summary>
        public async Task<(bool Success, UserResponseDto? User, string ErrorMessage)>
            LoginAsync(string email, string password)
        {
            // Cria os dados do login
            var loginDto = new LoginRequestDto
            {
                Email = email,
                Password = password
            };

            // Envia os dados para a API
            var (success, data, error) = await _http.PostAsync<UserResponseDto>(
                "/api/auth/login",
                loginDto);

            return (success, data, error);
        }

        /// <summary>
        /// Realiza o logout do usuário.
        /// </summary>
        public async Task<(bool Success, string ErrorMessage)> LogoutAsync()
        {
            // Chama o endpoint de logout da API
            var result = await _http.PostEmptyAsync(
                "/api/auth/logout");

            // Remove o cookie de sessão do Desktop
            _http.ClearCookies();

            return result;
        }

        /// <summary>
        /// Busca os dados do usuário que está logado.
        /// </summary>
        public async Task<UserResponseDto?> GetCurrentUserAsync()
        {
            return await _http.GetAsync<UserResponseDto>(
                "/api/auth/me");
        }

        /// <summary>
        /// Registra um novo usuário.
        /// </summary>
        public async Task<(bool Success, string ErrorMessage)> RegisterAsync(
            string email,
            string password,
            string confirmPassword)
        {
            // Cria os dados do cadastro
            var registerDto = new RegisterRequestDto
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            // Envia para a API
            var (success, _, error) = await _http.PostAsync<object>(
                "/api/auth/register",
                registerDto);

            return (success, error);
        }
    }
}