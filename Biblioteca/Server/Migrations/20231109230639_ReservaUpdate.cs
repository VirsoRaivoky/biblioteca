using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Server.Migrations
{
    /// <inheritdoc />
    public partial class ReservaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "LivroId",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "livroNome",
                table: "Reserva",
                newName: "LivroNome");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Reserva",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "alunoNome",
                table: "Reserva",
                newName: "AlunoNome");

            migrationBuilder.AddColumn<string>(
                name: "Turma",
                table: "Reserva",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Turma",
                table: "Reserva");

            migrationBuilder.RenameColumn(
                name: "LivroNome",
                table: "Reserva",
                newName: "livroNome");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Reserva",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "AlunoNome",
                table: "Reserva",
                newName: "alunoNome");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LivroId",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
