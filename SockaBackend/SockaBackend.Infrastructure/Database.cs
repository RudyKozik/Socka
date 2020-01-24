using Microsoft.EntityFrameworkCore;
using SockaBackend.Domain;
using System.Reflection;

namespace SockaBackend.Infrastructure
{
    public class Database : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Feed> Feeds { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public Database()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:ultimateweb.database.windows.net,1433;Initial Catalog=UltimateWeb;Persist Security Info=False;User ID=RudyK;Password=Aloha687;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

