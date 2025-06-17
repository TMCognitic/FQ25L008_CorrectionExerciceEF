using CorrectionExerciceEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorrectionExerciceEF.Domain.Configs
{
    internal class UtilisateurConfig : IEntityTypeConfiguration<Utilisateur>
    {
        public void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.ToTable(nameof(Utilisateur));

            builder.Property(p => p.Nom)
                .HasColumnType("NVARCHAR(50)");

            builder.Property(p => p.Prenom)
                .HasColumnType("NVARCHAR(50)");

            builder.Property(p => p.Email)
                .HasColumnType("NVARCHAR(384)");

            builder.Property(p => p.MotDePasse)
                .HasColumnType("BINARY(64)");

            builder.HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
