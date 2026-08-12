// =============================================================================
// Movies.Desktop - Services/CategoriesApiService.cs
// =============================================================================
//  CONCEITO: Service de Categorias (somente leitura)
//
// Como as categorias já existem no banco e não serão gerenciadas pelo
// sistema, este service implementa apenas:
//   GET /api/categories    Listar todas as categorias
// =============================================================================
using Movies.Desktop.DTOs;
using Movies.Desktop.Helpers;

namespace Movies.Desktop.Services
{
    /// <summary>
    /// Serviço de comunicação com o endpoint de Categorias da API.
    /// Somente leitura, já que as categorias são fixas neste projeto.
    /// </summary>
    public class CategoriasApiService
    {
        private readonly HttpClientHelper _http;

        public CategoriasApiService()
        {
            _http = HttpClientHelper.Instance;
        }

        /// <summary>
        /// Lista todas as categorias via GET /api/categories.
        /// </summary>
        public async Task<List<CategoriaResponseDto>> GetAllAsync()
        {
            try
            {
                var categorias = await _http.GetAsync<List<CategoriaResponseDto>>("/api/categories");
                return categorias ?? new List<CategoriaResponseDto>();
            }
            catch
            {
                return new List<CategoriaResponseDto>();
            }
        }
    }
}