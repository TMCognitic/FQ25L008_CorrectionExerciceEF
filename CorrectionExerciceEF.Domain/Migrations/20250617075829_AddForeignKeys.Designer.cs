﻿// <auto-generated />
using System;
using CorrectionExerciceEF.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CorrectionExerciceEF.Domain.Migrations
{
    [DbContext(typeof(CrowdfundingDbContext))]
    [Migration("20250617075829_AddForeignKeys")]
    partial class AddForeignKeys
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Contrepartie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(500)");

                    b.Property<int>("Montant")
                        .HasColumnType("int");

                    b.Property<int>("ProjetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjetId");

                    b.ToTable("Contrepartie", (string)null);
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Montant")
                        .HasColumnType("int");

                    b.Property<int>("ProjetId")
                        .HasColumnType("int");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjetId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Donation", (string)null);
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Participation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContrepartieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContrepartieId");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Participation", (string)null);
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Projet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("DATETIME2(7)");

                    b.Property<DateTime?>("DateFin")
                        .HasColumnType("DATE");

                    b.Property<DateTime?>("DateMiseEnLigne")
                        .HasColumnType("DATE");

                    b.Property<int>("Montant")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(128)");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UtilisateurId");

                    b.ToTable("Projet", (string)null);
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(384)");

                    b.Property<byte[]>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("BINARY(64)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateur", (string)null);
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Contrepartie", b =>
                {
                    b.HasOne("CorrectionExerciceEF.Domain.Entities.Projet", "Projet")
                        .WithMany("Contreparties")
                        .HasForeignKey("ProjetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Projet");
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Donation", b =>
                {
                    b.HasOne("CorrectionExerciceEF.Domain.Entities.Projet", "Projet")
                        .WithMany("Donations")
                        .HasForeignKey("ProjetId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CorrectionExerciceEF.Domain.Entities.Utilisateur", "Utilisateur")
                        .WithMany("Donations")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Projet");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Participation", b =>
                {
                    b.HasOne("CorrectionExerciceEF.Domain.Entities.Contrepartie", "Contrepartie")
                        .WithMany()
                        .HasForeignKey("ContrepartieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CorrectionExerciceEF.Domain.Entities.Utilisateur", "Utilisateur")
                        .WithMany("Participations")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Contrepartie");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Projet", b =>
                {
                    b.HasOne("CorrectionExerciceEF.Domain.Entities.Utilisateur", "Utilisateur")
                        .WithMany("Projets")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Projet", b =>
                {
                    b.Navigation("Contreparties");

                    b.Navigation("Donations");
                });

            modelBuilder.Entity("CorrectionExerciceEF.Domain.Entities.Utilisateur", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("Participations");

                    b.Navigation("Projets");
                });
#pragma warning restore 612, 618
        }
    }
}
