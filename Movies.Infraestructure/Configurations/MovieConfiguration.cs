using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Infraestructure.Configurations
{
    internal class MovieConfiguration: IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(g => g.Title)
                .IsRequired()           // Campo obrigatório
                .HasMaxLength(200);     // Máximo de 200 caracteres

            builder.Property(g => g.Description)
                .HasMaxLength(2000);    // Máximo de 2000 caracteres

            builder.Property(g => g.CoverImageUrl)
                .HasMaxLength(500);

            builder.HasOne(g => g.Category)      
                .WithMany(c => c.Movies)         
                .HasForeignKey(g => g.CategoryId)  // A FK é CategoryId
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
