using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace prueba.Migrations
{
    public partial class direcciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direciones_Clientes_ClienteId",
                table: "Direciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Direciones",
                table: "Direciones");

            migrationBuilder.RenameTable(
                name: "Direciones",
                newName: "Direcciones");

            migrationBuilder.RenameIndex(
                name: "IX_Direciones_ClienteId",
                table: "Direcciones",
                newName: "IX_Direcciones_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Direcciones",
                table: "Direcciones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Clientes_ClienteId",
                table: "Direcciones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Clientes_ClienteId",
                table: "Direcciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Direcciones",
                table: "Direcciones");

            migrationBuilder.RenameTable(
                name: "Direcciones",
                newName: "Direciones");

            migrationBuilder.RenameIndex(
                name: "IX_Direcciones_ClienteId",
                table: "Direciones",
                newName: "IX_Direciones_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Direciones",
                table: "Direciones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Direciones_Clientes_ClienteId",
                table: "Direciones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");
        }
    }
}
