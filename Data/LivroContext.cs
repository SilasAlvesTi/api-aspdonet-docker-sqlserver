using LivrosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrosApi.Data
{
    public sealed class LivroContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Livro[] livros = 
            [
                new Livro(new Guid("50b97e45-526c-4a8d-bddf-2d82e2f1b668"), "It a coisa"),
                new Livro(new Guid("50b97e45-526c-4a8d-bddf-2d82e2f1b669"), "Memórias Póstumas")
            ];

            modelBuilder.Entity<Livro>().HasData(livros);

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=db/Livros.db");
            optionsBuilder.UseSqlServer("Server=sql;User Id=sa;Password=SenhaDbLivros01;TrustServerCertificate=yes");
            base.OnConfiguring(optionsBuilder);
        }
    }
}