// See https://aka.ms/new-console-template for more information

using CorrectionExerciceEF.Domain;
using CorrectionExerciceEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

CrowdfundingDbContext context = new CrowdfundingDbContext();

Utilisateur? utilisateur = context.Utilisateurs
    .Include(u => u.Projets)
    .ThenInclude(u => u.Donations).SingleOrDefault(u => u.Id == 1);

if (utilisateur is not null)
{
    utilisateur.Projets.Add(new Projet() { Nom = "Test", Montant = 10000 });
    context.SaveChanges();

    foreach (Donation donation in utilisateur.Donations)
    {
        Console.WriteLine(donation.Montant);
    }

    foreach (Projet projet in utilisateur.Projets)
    {
        Console.WriteLine(projet.Nom);
    }
}
