using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clisoft.Infraestructure.Data.Migrations
{
    public partial class tableMascota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
    name: "Mascota");
            migrationBuilder.CreateTable(
    name: "Mascota",
    columns: table => new
    {
        idMascota = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
        nombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
        Genero = table.Column<string>(nullable: true),
        raza = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
        especie = table.Column<string>(nullable: true),
        idCliente = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Mascota", x => x.idMascota);
        table.ForeignKey(
            name: "FKMascotaCliente",
            column: x => x.idCliente,
            principalTable: "Cliente",
            principalColumn: "idCliente",
            onDelete: ReferentialAction.Restrict);
    });




            migrationBuilder.CreateIndex(
                name: "IX_Mascota_idCliente",
                table: "Mascota",
                column: "idCliente");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
