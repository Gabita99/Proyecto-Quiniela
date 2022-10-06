using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Quiniela.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "usuarios",
                newName: "Contra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "usuarios",
                newName: "Id_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contra",
                table: "usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Id_user",
                table: "usuarios",
                newName: "Id");
        }
    }
}
