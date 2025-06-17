namespace CorrectionExerciceEF.Domain.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public byte[] MotDePasse { get; set; }

        //Propriétés de navigation
        public virtual ICollection<Projet> Projets { get; set; } = new List<Projet>();
        public virtual IEnumerable<Donation> Donations { get; set; } = new List<Donation>();
        public virtual IEnumerable<Participation> Participations { get; set; } = new List<Participation>();
    }
}
