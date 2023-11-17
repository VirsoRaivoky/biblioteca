using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Server.Migrations
{
    /// <inheritdoc />
    public partial class ReservaATT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdLivro",
                table: "Reserva",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Situacao",
                table: "Reserva",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdLivro",
                table: "Reserva");

            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Reserva");
        }
    }
}
