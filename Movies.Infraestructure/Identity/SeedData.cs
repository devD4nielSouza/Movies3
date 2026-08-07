using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Movies.Domain.Entities;
using Movies.Infraestructure.Context;

namespace Movies.Infraestructure.Identity
{
    public static class SeedData
    {

        public static async Task SeedAsync(IServiceProvider serviceProvider)
        {
            // Obtém o DbContext do container de Dependency Injection
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<MoviesDbContext>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // Aplica migrations pendentes automaticamente
            await context.Database.MigrateAsync();

            // 1. SEED DE CATEGORIAS
            // =====================================================================
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Ação" },
                    new Category { Name = "Aventura" },
                    new Category { Name = "Drama" },
                    new Category { Name = "Suspense" },
                    new Category { Name = "Comédia" },
                    new Category { Name = "Terror" },
                    new Category { Name = "Ficção Científica" },
                    new Category { Name = "Romance" }
                };

                await context.Categories.AddRangeAsync(categories);
                await context.SaveChangesAsync();
            }

            // =====================================================================
            // 2. SEED DE MOVIES
            // =====================================================================
            if (!context.Movies.Any())
            {
                // Busca as categorias recém-criadas para obter os IDs
                var acao = await context.Categories.FirstAsync(c => c.Name == "Ação");
                var aventura = await context.Categories.FirstAsync(c => c.Name == "Aventura");
                var drama = await context.Categories.FirstAsync(c => c.Name == "Drama");
                var suspense = await context.Categories.FirstAsync(c => c.Name == "Suspense");
                var terror = await context.Categories.FirstAsync(c => c.Name == "Terror");
                var comedia = await context.Categories.FirstAsync(c => c.Name == "Comédia");
                var ficcao = await context.Categories.FirstAsync(c => c.Name == "Ficção Científica");
                var romance = await context.Categories.FirstAsync(c => c.Name == "Romance");

                var movies = new List<Movie>
                {
                    new Movie
                    {
                        Title = "Batman: O Cavaleiro das Trevas",
                        Description = "Situado um ano após os eventos de Batman Begins (2005), Batman, o tenente James Gordon e o novo promotor público Harvey Dent começam a prender com sucesso os criminosos que assolam Gotham City, até que um misterioso e sádico gênio do crime conhecido apenas como “O Coringa” aparece em Gotham, criando uma nova onda de caos. A luta de Batman contra o Coringa se torna profundamente pessoal, forçando-o a “confrontar tudo em que acredita” e melhorar sua tecnologia para detê-lo. Um triângulo amoroso se desenvolve entre Bruce Wayne, Dent e Rachel Dawes.",
                        ReleaseDate = 2008,
                        CoverImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQvj3mqIv1k7wjZrOsArp-dOeBU6v_BjJgPfM7RWMpBCOc5UYjRduxIq263ucVeVFJ59QVgIsx0QDHF0cijyT5jM0rj0QlAOAtm8REnlQ&s=10",
                        CategoryId = acao.Id,
                        CreatedAt = DateTime.Now
                    },
                    new Movie
                    {
                        Title = "O Poderoso Chefão",
                        Description = "Don Vito Corleone é o chefe de uma poderosa família mafiosa em Nova York no final dos anos 1940. Quando ele recusa entrar no tráfico de drogas e sofre um atentado quase fatal, seu filho caçula, Michael — antes distante dos crimes —, assume a vingança e inicia sua transformação em um implacável novo chefão",
                        ReleaseDate = 1972,
                        CoverImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRK6RVMLsO0DKQkHyuzaqHIS93nmApc1WHy2kEmmPMm3A&s=10",
                        CategoryId = drama.Id,
                       
                        CreatedAt = DateTime.Now
                    },
                    new Movie
                    {
                        Title = "Spider-Man 2",
                        Description = "Marvel's Spider-Man 2",
                        ReleaseDate = 2004,
                        CoverImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSTzRAmpyGgRJvbtSmcgsMzqN2gtFGNwfj8aqrF-FVpIuMzZZ6f0wh_9PALEWD9YBGWKV5dsEHQlXU3nDnYYHkgphFhkM4aj6ir4SWm8w&s=10",
                        CategoryId = acao.Id,
                       
                        CreatedAt = DateTime.Now
                    },
                    new Movie
                    {
                        Title = "Matrix",
                        Description = "O programador e hacker Thomas Anderson, conhecido como Neo, descobre que a humanidade vive presa em uma simulação virtual chamada Matrix. Guiado por Morpheus e Trinity, ele aprende a lutar contra máquinas que usam os corpos humanos como energia e aceita o destino de ser o Escolhido para libertar a nossa espécie",
                        ReleaseDate = 1999,
                        CoverImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSEbjrQIyuZlEZBypKX7sIJf2NDSCYJ_3ioCOfekqIR7A&s",
                        CategoryId = ficcao.Id,
                       
                        CreatedAt = DateTime.Now
                    },
                    new Movie
                    {
                        Title = "Forrest Gump",
                        Description = "Forrest Gump: O Contador de Histórias (1994) acompanha a vida de Forrest (Tom Hanks), um homem bondoso do Alabama com um QI abaixo da média. Guiado pelos ensinamentos de sua mãe, ele presencia e influencia momentos marcantes da história dos Estados Unidos enquanto busca o amor de sua infância, Jenny",
                        ReleaseDate = 1994,
                        CoverImageUrl = "https://upload.wikimedia.org/wikipedia/pt/c/c0/ForrestGumpPoster.jpg",
                        CategoryId = comedia.Id,
                       
                        CreatedAt = DateTime.Now
                    },
                    new Movie
                    {
                        Title = "Seven os sete crimes capitais",
                        Description = "O filme Seven: Os Sete Crimes Capitais (1995), dirigido por David Fincher, acompanha dois detetives — o veterano William Somerset (Morgan Freeman) e o novato impetuoso David Mills (Bratt Pitt) — em uma corrida contra o tempo para caçar um serial killer que baseia seus assassinatos sádicos nos sete pecados capitais",
                        ReleaseDate = 1995,
                        CoverImageUrl = "https://br.web.img3.acsta.net/pictures/210/124/21012465_2013061319170245.jpg",
                        CategoryId = suspense.Id,
                        
                        CreatedAt = DateTime.Now
                    },
                    new Movie
                    {
                        Title = "A origem",
                        Description = "Dom Cobb (Leonardo DiCaprio) é um ladrão que rouba segredos do subconsciente durante o sono. Para poder rever seus filhos e limpar seu nome, ele aceita uma missão quase impossível: plantar uma ideia na mente de um herdeiro empresarial, navegando por complexas camadas de sonhos",
                        ReleaseDate = 2010,
                        CoverImageUrl = "https://br.web.img3.acsta.net/c_310_420/medias/nmedia/18/87/32/31/20028688.jpg",
                        CategoryId = terror.Id,
                       
                        CreatedAt = DateTime.Now
                    },
                    new Movie
                    {
                        Title = "Senhor dos Aneis",
                        Description = "O Senhor dos Anéis narra a grande jornada do hobbit Frodo Bolseiro na Terra-Média. Ele precisa destruir o Um Anel e impedir o retorno do Senhor do Escuro, Sauron. Para isso, conta com a ajuda de uma união de homens, elfos, anões, magos e outros hobbits",
                        ReleaseDate = 2002,
                        CoverImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdxE2On9adlbBea5CnZ92M_USVVKAxNiyCornRY9hyrQ&s=10",
                        CategoryId = aventura.Id,
                       
                        CreatedAt = DateTime.Now
                    }
                };

                await context.Movies.AddRangeAsync(movies);
                await context.SaveChangesAsync();
            }

            // =====================================================================
            // 3. SEED DE ROLES (Papéis de Usuário)
            // =====================================================================
            //  CONCEITO: Roles no Identity
            // Roles são papéis que definem o nível de acesso do usuário.
            // Exemplo: "Admin" pode gerenciar games, "User" só pode visualizar.
            // =====================================================================
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            // =====================================================================
            // 4. SEED DO USUÁRIO ADMINISTRADOR
            // =====================================================================
            //  CONCEITO: UserManager
            // O UserManager é o serviço do Identity para gerenciar usuários.
            // Ele permite criar, buscar, atualizar e deletar usuários.
            // =====================================================================
            var adminEmail = "admin@email.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true // Confirma o email automaticamente
                };

                // Cria o usuário com a senha padrão
                var result = await userManager.CreateAsync(adminUser, "Admin@123");

                if (result.Succeeded)
                {
                    // Atribui a role "Admin" ao usuário
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }
}
