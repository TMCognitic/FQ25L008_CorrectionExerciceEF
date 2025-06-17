namespace CorrectionExerciceEF.Domain.Entities
{
    public class Participation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int UtilisateurId { get; set; }
        public int ContrepartieId { get; set; }

        //Propriétés de navigation
        public virtual Utilisateur Utilisateur { get; set; } = default!;
        public virtual Contrepartie Contrepartie { get; set; } = default!;
    }
}
