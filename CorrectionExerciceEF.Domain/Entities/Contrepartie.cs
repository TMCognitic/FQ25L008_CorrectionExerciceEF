namespace CorrectionExerciceEF.Domain.Entities
{
    public class Contrepartie
    {
        public int Id { get; set; }
        public int Montant { get; set; }
        public string Description { get; set; }
        public int ProjetId { get; set; }

        //propriété de navigation
        public virtual Projet Projet { get; set; } = default!;
    }
}
