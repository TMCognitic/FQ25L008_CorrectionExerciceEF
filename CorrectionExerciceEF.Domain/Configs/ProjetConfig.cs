using CorrectionExerciceEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorrectionExerciceEF.Domain.Configs
{
    internal class ProjetConfig : IEntityTypeConfiguration<Projet>
    {
        public void Configure(EntityTypeBuilder<Projet> builder)
        {
            builder.ToTable(nameof(Projet), t =>
            {
                t.HasCheckConstraint("CK_Contrepartie_Montant", "Montant > 1000");
                t.HasCheckConstraint("CK_Contrepartie_DateMiseEnLigne", "DateMiseEnLigne > DateCreation");
                t.HasCheckConstraint("CK_Contrepartie_DateFin", "DateFin > DateMiseEnLigne");                
            });

            builder.Property(p => p.Nom)
                .HasColumnType("NVARCHAR(128)");

            builder.Property(p => p.DateCreation)
                .HasColumnType("DATETIME2(7)")
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.DateMiseEnLigne)
                .HasColumnType("DATE");

            builder.Property(p => p.DateFin)
                .HasColumnType("DATE");

            builder.HasOne(p => p.Utilisateur)
                .WithMany(u => u.Projets)
                .HasForeignKey(p => p.UtilisateurId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
