// =============================================================================
// Movies.API - CategoriesController
// =============================================================================
// Controller REST para operações com Categorias.
//
// Endpoints:
// GET    /api/categories        Lista todas as categorias (público)
// POST   /api/categories        Cria uma nova categoria (Admin)
// PUT    /api/categories/{id}   Atualiza uma categoria (Admin)
// DELETE /api/categories/{id}   Remove uma categoria (Admin)
//
// Observação: neste projeto as categorias são fixas (não gerenciadas pela
// tela do Desktop), então apenas o GET é efetivamente consumido pelo
// cliente. Os demais endpoints seguem disponíveis na API, protegidos por
// [Authorize(Roles = "Admin")], caso sejam necessários no futuro.
// =============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Application.DTOs;
using Movies.Application.Interfaces;

namespace Movies.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Retorna todas as categorias.
        /// GET /api/categories
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        /// <summary>
        /// Retorna uma categoria específica pelo Id.
        /// GET /api/categories/{id}
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            if (category == null)
                return NotFound(new { message = "Categoria não encontrada." });

            return Ok(category);
        }

        /// <summary>
        /// Cria uma nova categoria.
        /// POST /api/categories
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CategoryDto>> Create([FromBody] CreateCategoryDto dto)
        {
            var category = await _categoryService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }

        /// <summary>
        /// Atualiza uma categoria existente.
        /// PUT /api/categories/{id}
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CategoryDto>> Update(int id, [FromBody] UpdateCategoryDto dto)
        {
            var category = await _categoryService.UpdateAsync(id, dto);

            if (category == null)
                return NotFound(new { message = "Categoria não encontrada." });

            return Ok(category);
        }

        /// <summary>
        /// Remove uma categoria.
        /// DELETE /api/categories/{id}
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _categoryService.DeleteAsync(id);

            if (!deleted)
                return NotFound(new { message = "Categoria não encontrada." });

            return NoContent();
        }
    }
}