namespace CorrectionExerciceEF.Domain.Entities
{
    public class Donation
    {
        public int Id { get; set; }
        public int Montant { get; set; }
        public DateTime Date { get; set; }
        public int UtilisateurId { get; set; }
        public int ProjetId { get; set; }

        //Propriétés de navigation
        public virtual Utilisateur Utilisateur { get; set; } = default!;
        public virtual Projet Projet { get; set; } = default!;
    }
}
