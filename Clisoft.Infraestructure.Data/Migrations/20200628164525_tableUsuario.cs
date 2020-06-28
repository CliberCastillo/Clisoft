using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clisoft.Infraestructure.Data.Migrations
{
    public partial class tableUsuario : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
    name: "Mascota");

            migrationBuilder.DropTable(
                name: "PerfilExamen");

            migrationBuilder.DropTable(
                name: "Resultado");

            migrationBuilder.DropTable(
                name: "DetalleOrden");

            migrationBuilder.DropTable(
                name: "Examen");

            migrationBuilder.DropTable(
                name: "Orden");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Usuario");
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    idCargo = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.idCargo);
                });

            migrationBuilder.CreateTable(
                name: "Examen",
                columns: table => new
                {
                    idExamen = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    tipo = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examen", x => x.idExamen);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    idPerfil = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    costo = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.idPerfil);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idUsuario = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombreUsuario = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    contraseña = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idUsuario);
                });

            migrationBuilder.CreateTable(
                name: "PerfilExamen",
                columns: table => new
                {
                    idPerfilExamen = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idPerfil = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idExamen = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombreExamen = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilExamen", x => x.idPerfilExamen);
                    table.ForeignKey(
                        name: "FKPerfilExamenExamen",
                        column: x => x.idExamen,
                        principalTable: "Examen",
                        principalColumn: "idExamen",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKPerfilExamenPerfil",
                        column: x => x.idPerfil,
                        principalTable: "Perfil",
                        principalColumn: "idPerfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    apellido = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    direccion = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    telefono = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    nombreContacto = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    distrito = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    estado = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    idUsuario = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                    table.ForeignKey(
                        name: "FKClienteUSuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    idEmpleado = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    apellidos = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    dni = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    telefono = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    sueldo = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    estado = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    idUsuario = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idCargo = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.idEmpleado);
                    table.ForeignKey(
                        name: "FKEmpleadoCargo",
                        column: x => x.idCargo,
                        principalTable: "Cargo",
                        principalColumn: "idCargo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKEmpleadoUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuario",
                        principalColumn: "idUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    idMascota = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    raza = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    idOrden = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    estado = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    fechaRegistro = table.Column<DateTime>(type: "datetime", nullable: false),
                    resultado = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    idCliente = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idEmpleado = table.Column<string>(unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.idOrden);
                    table.ForeignKey(
                        name: "FKOrdenCliente",
                        column: x => x.idCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKOrdenEmpleado",
                        column: x => x.idEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "idEmpleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleOrden",
                columns: table => new
                {
                    idDetalleOrden = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idPerfil = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idOrden = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    costoServicio = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleOrden", x => x.idDetalleOrden);
                    table.ForeignKey(
                        name: "FKDetalleOrdenOrden",
                        column: x => x.idOrden,
                        principalTable: "Orden",
                        principalColumn: "idOrden",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKDetalleOrdenPerfil",
                        column: x => x.idPerfil,
                        principalTable: "Perfil",
                        principalColumn: "idPerfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resultado",
                columns: table => new
                {
                    idResultado = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idExamen = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    idDetalleOrden = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    resultado = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultado", x => x.idResultado);
                    table.ForeignKey(
                        name: "FKResultadoDetalleOrden",
                        column: x => x.idDetalleOrden,
                        principalTable: "DetalleOrden",
                        principalColumn: "idDetalleOrden",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FKResultadoExamen",
                        column: x => x.idExamen,
                        principalTable: "Examen",
                        principalColumn: "idExamen",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_idUsuario",
                table: "Cliente",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_idOrden",
                table: "DetalleOrden",
                column: "idOrden");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_idPerfil",
                table: "DetalleOrden",
                column: "idPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_idCargo",
                table: "Empleado",
                column: "idCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_idUsuario",
                table: "Empleado",
                column: "idUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_idCliente",
                table: "Mascota",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_idCliente",
                table: "Orden",
                column: "idCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_idEmpleado",
                table: "Orden",
                column: "idEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilExamen_idExamen",
                table: "PerfilExamen",
                column: "idExamen");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilExamen_idPerfil",
                table: "PerfilExamen",
                column: "idPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_Resultado_idDetalleOrden",
                table: "Resultado",
                column: "idDetalleOrden");

            migrationBuilder.CreateIndex(
                name: "IX_Resultado_idExamen",
                table: "Resultado",
                column: "idExamen");
        }
    }
}
