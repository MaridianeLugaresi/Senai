using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Exo.WebApi.Models;
namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext(){}

        public ExoContext(DbContextOptions<ExoContext> options) : base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;" + "Database=ExoApi;Trusted_Connection=True;");
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}