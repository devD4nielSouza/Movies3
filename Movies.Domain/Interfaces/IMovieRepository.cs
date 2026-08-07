using Movies.Domain.Entities;

namespace Movies.Domain.Interfaces
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie?> GetByIdAsync(int id);
        Task<IEnumerable<Movie>> GetFeaturedAsync();
        Task<IEnumerable<Movie>> GetByCategoryAsync(int categoryId);
        Task AddAsync(Movie movie);
        Task UpdateAsync(Movie movie);
        Task DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
