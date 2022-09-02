using FilmBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FilmBase.Data
{
    public class FilmsDbContext : DbContext
    {
        public FilmsDbContext() : base()
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=FilmsDB;Trusted_Connection=True;");
        }
    }
}
