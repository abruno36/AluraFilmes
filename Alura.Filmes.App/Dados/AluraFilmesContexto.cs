using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Filmes.App.Dados
{
    public class AluraFilmesContexto : DbContext
    {
        public DbSet<Ator> actor { get; set; }
        public DbSet<Filme> film { get; set; }
        public DbSet<FilmeAtor> Elenco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Initial Catalog=AluraFilmes; Integrated Security=True");

      
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
        }
    }
}
