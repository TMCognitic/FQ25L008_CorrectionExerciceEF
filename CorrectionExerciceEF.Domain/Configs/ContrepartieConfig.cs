using CorrectionExerciceEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorrectionExerciceEF.Domain.Configs
{
    internal class ContrepartieConfig : IEntityTypeConfiguration<Contrepartie>
    {
        public void Configure(EntityTypeBuilder<Contrepartie> builder)
        {
            builder.ToTable(nameof(Contrepartie), t =>
                {
                    t.HasCheckConstraint("CK_Contrepartie_Montant", "Montant > 0");
                });

            builder.Property(c => c.Description)
                .HasColumnType("NVARCHAR(500)");

            builder.HasOne(c => c.Projet)
                .WithMany(p => p.Contreparties)
                .HasForeignKey(c => c.ProjetId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
