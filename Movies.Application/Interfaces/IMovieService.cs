using Movies.Application.DTOs;


namespace Movies.Application.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MoviesDto>> GetAllAsync();
        Task<MoviesDto?> GetByIdAsync(int id);
        Task<IEnumerable<MoviesDto>> GetByCategoryAsync(int categoryId);
        Task<MoviesDto> CreateAsync(CreateMovieDto dto);
        Task<MoviesDto?> UpdateAsync(int id, UpdateMovieDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
