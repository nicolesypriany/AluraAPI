using AluraNET6WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AluraNET6WebApi.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext()
        {
            
        }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FilmesAPI;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }

    }
}
