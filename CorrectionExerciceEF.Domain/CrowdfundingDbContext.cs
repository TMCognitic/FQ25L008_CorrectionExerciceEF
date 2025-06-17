using CorrectionExerciceEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CorrectionExerciceEF.Domain
{
    public class CrowdfundingDbContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get { return Set<Utilisateur>(); } }
        public DbSet<Projet> Projets { get { return Set<Projet>(); } }
        public DbSet<Contrepartie> Contreparties { get { return Set<Contrepartie>(); } }
        public DbSet<Donation> Donations { get { return Set<Donation>(); } }
        public DbSet<Participation> Participations { get { return Set<Participation>(); } }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CrowdfundingExoEF;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;")
                          .LogTo(Console.WriteLine, [DbLoggerCategory.Database.Command.Name], LogLevel.Information)
                          .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
