using CorrectionExerciceEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CorrectionExerciceEF.Domain.Configs
{
    internal class ParticipationConfig : IEntityTypeConfiguration<Participation>
    {
        public void Configure(EntityTypeBuilder<Participation> builder)
        {
            builder.ToTable(nameof(Participation));

            builder.Property(d => d.Date)
                .HasDefaultValueSql("SYSDATETIME()")
                .ValueGeneratedOnAdd();

            builder.HasOne(p => p.Utilisateur)
                .WithMany(u => u.Participations)
                .HasForeignKey(p => p.UtilisateurId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(p => p.Contrepartie)
                .WithMany()
                .HasForeignKey(p => p.ContrepartieId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
