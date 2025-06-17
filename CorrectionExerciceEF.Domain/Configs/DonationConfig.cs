using CorrectionExerciceEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;

namespace CorrectionExerciceEF.Domain.Configs
{
    internal class DonationConfig : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.ToTable(nameof(Donation));

            builder.Property(d => d.Date)
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnAdd();

            builder.HasOne(d => d.Utilisateur)
                .WithMany(u => u.Donations)
                .HasForeignKey(d => d.UtilisateurId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(d => d.Projet)
                .WithMany(p => p.Donations)
                .HasForeignKey(d => d.ProjetId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
