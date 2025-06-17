using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CorrectionExerciceEF.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddCheck_DefaultAndUniqueContraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Projet",
                type: "DATETIME2(7)",
                nullable: false,
                defaultValueSql: "SYSDATETIME()",
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2(7)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Participation",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "SYSDATETIME()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Donation",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "SYSDATETIME()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_Email",
                table: "Utilisateur",
                column: "Email",
                unique: true);

            migrationBuilder.AddCheckConstraint(
                name: "CK_Projet_DateFin",
                table: "Projet",
                sql: "DateFin > DateMiseEnLigne");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Projet_DateMiseEnLigne",
                table: "Projet",
                sql: "DateMiseEnLigne > DateCreation");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Projet_Montant",
                table: "Projet",
                sql: "Montant > 1000");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Donation_Montant",
                table: "Donation",
                sql: "Montant > 0");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Contrepartie_Montant",
                table: "Contrepartie",
                sql: "Montant > 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_Email",
                table: "Utilisateur");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Projet_DateFin",
                table: "Projet");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Projet_DateMiseEnLigne",
                table: "Projet");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Projet_Montant",
                table: "Projet");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Donation_Montant",
                table: "Donation");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Contrepartie_Montant",
                table: "Contrepartie");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Projet",
                type: "DATETIME2(7)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME2(7)",
                oldDefaultValueSql: "SYSDATETIME()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Participation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "SYSDATETIME()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Donation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "SYSDATETIME()");
        }
    }
}
