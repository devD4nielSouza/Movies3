using Movies.Application.DTOs;


namespace Movies.Application.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieDto>> GetAllAsync();
        Task<MovieDto?> GetByIdAsync(int id);
        Task<IEnumerable<MovieDto>> GetByCategoryAsync(int categoryId);
        Task<MovieDto> CreateAsync(CreateMovieDto dto);
        Task<MovieDto?> UpdateAsync(int id, UpdateMovieDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
