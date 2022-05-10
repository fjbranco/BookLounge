using BookLounge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookLounge.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define as tabelas na base de dados
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Encomenda> Encomendas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Genero> Temas { get; set; }
        public DbSet<EncomendaLivro> EncomendaLivros { get; set; }

    }
}