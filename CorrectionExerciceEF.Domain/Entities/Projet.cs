namespace CorrectionExerciceEF.Domain.Entities
{
    public class Projet
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Montant { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateMiseEnLigne { get; set; }
        public DateTime? DateFin { get; set; }
        public int UtilisateurId { get; set; }

        //Propriété de navigation
        public virtual Utilisateur Utilisateur { get; set; } = default!;
        public virtual IEnumerable<Donation> Donations { get; set; } = new List<Donation>();
        public virtual ICollection<Contrepartie> Contreparties { get; set; } = new List<Contrepartie>();
    }
}
