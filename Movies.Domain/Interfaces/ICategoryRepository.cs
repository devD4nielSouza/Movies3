using Movies.Domain.Entities;

namespace Movies.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        /// <summary>
        /// Retorna todas as categorias do banco de dados.
        /// </summary>
        Task<IEnumerable<Category>> GetAllAsync();

        /// <summary>
        /// Busca uma categoria específica pelo seu Id.
        /// </summary>
        Task<Category?> GetByIdAsync(int id);

        /// <summary>
        /// Adiciona uma nova categoria ao banco de dados.
        /// </summary>
        Task AddAsync(Category category);

        /// <summary>
        /// Atualiza os dados de uma categoria existente.
        /// </summary>
        Task UpdateAsync(Category category);

        /// <summary>
        /// Remove uma categoria do banco de dados.
        /// </summary>
        Task DeleteAsync(int id);

        /// <summary>
        /// Retorna o total de categorias cadastradas.
        /// </summary>
        Task<int> CountAsync();
    }
}
