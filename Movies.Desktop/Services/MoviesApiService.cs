
using Movies.Desktop.DTOs;
using Movies.Desktop.Helpers;

namespace Movies.Desktop.Services
{
    /// <summary>
    /// Serviço responsável pela comunicação com os endpoints de filmes da API.
    /// </summary>
    public class MoviesApiService
    {
        private readonly HttpClientHelper _http;

        public MoviesApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        /// <summary>
        /// Lista todos os filmes.
        /// </summary>
        public async Task<List<MovieResponseDto>> GetAllAsync()
        {
            try
            {
                var movies = await _http.GetAsync<List<MovieResponseDto>>(
                    "/api/movies");

                return movies ?? new List<MovieResponseDto>();
            }
            catch
            {
                return new List<MovieResponseDto>();
            }
        }

        /// <summary>
        /// Busca um filme pelo ID.
        /// </summary>
        public async Task<MovieResponseDto?> GetByIdAsync(int id)
        {
            return await _http.GetAsync<MovieResponseDto>(
                $"/api/movies/{id}");
        }

        /// <summary>
        /// Cria um novo filme.
        /// </summary>
        public async Task<(bool Success, MovieResponseDto? Movie, string ErrorMessage)>
            CreateAsync(CreateMovieDto dto)
        {
            return await _http.PostAsync<MovieResponseDto>(
                "/api/movies",
                dto);
        }

        /// <summary>
        /// Atualiza um filme existente.
        /// </summary>
        public async Task<(bool Success, MovieResponseDto? Movie, string ErrorMessage)>
            UpdateAsync(int id, UpdateMovieDto dto)
        {
            return await _http.PutAsync<MovieResponseDto>(
                $"/api/movies/{id}",
                dto);
        }

        /// <summary>
        /// Exclui um filme.
        /// </summary>
        public async Task<(bool Success, string ErrorMessage)>
            DeleteAsync(int id)
        {
            return await _http.DeleteAsync(
                $"/api/movies/{id}");
        }
    }
}