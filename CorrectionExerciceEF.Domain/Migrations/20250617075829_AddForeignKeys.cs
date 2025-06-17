using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectionExerciceEF.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UtilisateurId",
                table: "Projet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContrepartieId",
                table: "Participation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UtilisateurId",
                table: "Participation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjetId",
                table: "Donation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UtilisateurId",
                table: "Donation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjetId",
                table: "Contrepartie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Projet_UtilisateurId",
                table: "Projet",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Participation_ContrepartieId",
                table: "Participation",
                column: "ContrepartieId");

            migrationBuilder.CreateIndex(
                name: "IX_Participation_UtilisateurId",
                table: "Participation",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_ProjetId",
                table: "Donation",
                column: "ProjetId");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_UtilisateurId",
                table: "Donation",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_Contrepartie_ProjetId",
                table: "Contrepartie",
                column: "ProjetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contrepartie_Projet_ProjetId",
                table: "Contrepartie",
                column: "ProjetId",
                principalTable: "Projet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_Projet_ProjetId",
                table: "Donation",
                column: "ProjetId",
                principalTable: "Projet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Donation_Utilisateur_UtilisateurId",
                table: "Donation",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Participation_Contrepartie_ContrepartieId",
                table: "Participation",
                column: "ContrepartieId",
                principalTable: "Contrepartie",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Participation_Utilisateur_UtilisateurId",
                table: "Participation",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projet_Utilisateur_UtilisateurId",
                table: "Projet",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contrepartie_Projet_ProjetId",
                table: "Contrepartie");

            migrationBuilder.DropForeignKey(
                name: "FK_Donation_Projet_ProjetId",
                table: "Donation");

            migrationBuilder.DropForeignKey(
                name: "FK_Donation_Utilisateur_UtilisateurId",
                table: "Donation");

            migrationBuilder.DropForeignKey(
                name: "FK_Participation_Contrepartie_ContrepartieId",
                table: "Participation");

            migrationBuilder.DropForeignKey(
                name: "FK_Participation_Utilisateur_UtilisateurId",
                table: "Participation");

            migrationBuilder.DropForeignKey(
                name: "FK_Projet_Utilisateur_UtilisateurId",
                table: "Projet");

            migrationBuilder.DropIndex(
                name: "IX_Projet_UtilisateurId",
                table: "Projet");

            migrationBuilder.DropIndex(
                name: "IX_Participation_ContrepartieId",
                table: "Participation");

            migrationBuilder.DropIndex(
                name: "IX_Participation_UtilisateurId",
                table: "Participation");

            migrationBuilder.DropIndex(
                name: "IX_Donation_ProjetId",
                table: "Donation");

            migrationBuilder.DropIndex(
                name: "IX_Donation_UtilisateurId",
                table: "Donation");

            migrationBuilder.DropIndex(
                name: "IX_Contrepartie_ProjetId",
                table: "Contrepartie");

            migrationBuilder.DropColumn(
                name: "UtilisateurId",
                table: "Projet");

            migrationBuilder.DropColumn(
                name: "ContrepartieId",
                table: "Participation");

            migrationBuilder.DropColumn(
                name: "UtilisateurId",
                table: "Participation");

            migrationBuilder.DropColumn(
                name: "ProjetId",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "UtilisateurId",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "ProjetId",
                table: "Contrepartie");
        }
    }
}
