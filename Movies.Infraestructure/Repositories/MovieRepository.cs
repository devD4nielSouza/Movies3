using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entities;
using Movies.Domain.Interfaces;
using Movies.Infraestructure.Context;

namespace Movies.Infraestructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext _context;

        public MovieRepository(MoviesDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await _context.Movies
                .Include(g => g.Category)  // Faz JOIN com a tabela Categories
                .OrderByDescending(g => g.CreatedAt)
                .ToListAsync();
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await _context.Movies
                .Include(g => g.Category)
                .FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Movies
                .Include(g => g.Category)
                .Where(g => g.CategoryId == categoryId)
                .ToListAsync();
        }

        public async Task AddAsync(Movie game)
        {
            await _context.Movies.AddAsync(game);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Movie game)
        {
            _context.Movies.Update(game);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var game = await _context.Movies.FindAsync(id);
            if (game != null)
            {
                _context.Movies.Remove(game);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> CountAsync()
        {
            return await _context.Movies.CountAsync();
        }
    }
}
