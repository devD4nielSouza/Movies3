using Movies.Application.DTOs;
using Movies.Application.Interfaces;
using Movies.Domain.Entities;
using Movies.Domain.Interfaces;

namespace Movies.Application.Services
{
    public class MovieService: IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<MovieDto>> GetAllAsync()
        {
            var movies = await _movieRepository.GetAllAsync();
            return movies.Select(MapToDto);
        }

        public async Task<MovieDto?> GetByIdAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            return movie == null ? null : MapToDto(movie);
        }

        public async Task<IEnumerable<MovieDto>> GetFeaturedAsync()
        {
            var movies = await _movieRepository.GetFeaturedAsync();
            return movies.Select(MapToDto);
        }

        public async Task<IEnumerable<MovieDto>> GetByCategoryAsync(int categoryId)
        {
            var movies = await _movieRepository.GetByCategoryAsync(categoryId);
            return movies.Select(MapToDto);
        }

        public async Task<MovieDto> CreateAsync(CreateMovieDto dto)
        {
            // Mapeia o DTO de criação para a entidade Movie
            var movie = new Movie
            {
                Title = dto.Title,
                Description = dto.Description,
                ReleaseDate = dto.ReleaseDate,
                CoverImageUrl = dto.CoverImageUrl,
                CategoryId = dto.CategoryId,
                CreatedAt = DateTime.Now
            };

            await _movieRepository.AddAsync(movie);

            // Retorna o game criado como DTO
            return MapToDto(movie);
        }

        public async Task<MovieDto?> UpdateAsync(int id, UpdateMovieDto dto)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            if (movie == null) return null;

            // Atualiza os campos do game com os dados do DTO
            movie.Title = dto.Title;
            movie.Description = dto.Description;
            movie.ReleaseDate = dto.ReleaseDate;
            movie.CoverImageUrl = dto.CoverImageUrl;
            movie.CategoryId = dto.CategoryId;

            await _movieRepository.UpdateAsync(movie);
            return MapToDto(movie);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            if (movie == null) return false;

            await _movieRepository.DeleteAsync(id);
            return true;
        }

        public async Task<int> CountAsync()
        {
            return await _movieRepository.CountAsync();
        }

        private static MovieDto MapToDto(Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
                CoverImageUrl = movie.CoverImageUrl,
                CategoryId = movie.CategoryId,
                CategoryName = movie.Category?.Name ?? string.Empty,
                CreatedAt = movie.CreatedAt
            };
        }
    }
}
