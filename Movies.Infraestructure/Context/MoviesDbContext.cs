using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Movies.Domain.Entities;
using Movies.Infraestructure.Configurations;

namespace Movies.Infraestructure.Context
{
    public class MoviesDbContext : IdentityDbContext
    {

        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
        : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // IMPORTANTE: Sempre chamar base.OnModelCreating() quando herdar
            // de IdentityDbContext, para que as tabelas do Identity sejam criadas.
            base.OnModelCreating(modelBuilder);

            // Aplica as configurações de cada entidade (definidas em classes separadas)
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
    }
}
