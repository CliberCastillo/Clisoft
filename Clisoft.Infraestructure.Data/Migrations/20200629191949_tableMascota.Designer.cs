﻿// <auto-generated />
using System;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clisoft.Infraestructure.Data.Migrations
{
    [DbContext(typeof(ClisoftContext))]
    [Migration("20200629191949_tableMascota")]
    partial class tableMascota
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clisoft.Domain.Entities.Cargo", b =>
                {
                    b.Property<string>("IdCargo")
                        .HasColumnName("idCargo")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdCargo");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Cliente", b =>
                {
                    b.Property<string>("IdCliente")
                        .HasColumnName("idCliente")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnName("direccion")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Distrito")
                        .IsRequired()
                        .HasColumnName("distrito")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("estado")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnName("idUsuario")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("NombreContacto")
                        .IsRequired()
                        .HasColumnName("nombreContacto")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40)
                        .IsUnicode(false);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnName("telefono")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("IdCliente");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.DetalleOrden", b =>
                {
                    b.Property<string>("IdDetalleOrden")
                        .HasColumnName("idDetalleOrden")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<decimal>("CostoServicio")
                        .HasColumnName("costoServicio")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("IdOrden")
                        .IsRequired()
                        .HasColumnName("idOrden")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("IdPerfil")
                        .IsRequired()
                        .HasColumnName("idPerfil")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.HasKey("IdDetalleOrden");

                    b.HasIndex("IdOrden");

                    b.HasIndex("IdPerfil");

                    b.ToTable("DetalleOrden");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Empleado", b =>
                {
                    b.Property<string>("IdEmpleado")
                        .HasColumnName("idEmpleado")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnName("dni")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("estado")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("IdCargo")
                        .IsRequired()
                        .HasColumnName("idCargo")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnName("idUsuario")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<decimal>("Sueldo")
                        .HasColumnName("sueldo")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnName("telefono")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("IdEmpleado");

                    b.HasIndex("IdCargo");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Examen", b =>
                {
                    b.Property<string>("IdExamen")
                        .HasColumnName("idExamen")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnName("tipo")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdExamen");

                    b.ToTable("Examen");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Mascota", b =>
                {
                    b.Property<string>("IdMascota")
                        .HasColumnName("idMascota")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Especie")
                        .HasColumnName("Especie1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCliente")
                        .IsRequired()
                        .HasColumnName("idCliente")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Especie")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnName("raza")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdMascota");

                    b.HasIndex("IdCliente");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Orden", b =>
                {
                    b.Property<string>("IdOrden")
                        .HasColumnName("idOrden")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnName("estado")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnName("fechaRegistro")
                        .HasColumnType("datetime");

                    b.Property<string>("IdCliente")
                        .IsRequired()
                        .HasColumnName("idCliente")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("IdEmpleado")
                        .IsRequired()
                        .HasColumnName("idEmpleado")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasColumnName("resultado")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("IdOrden");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEmpleado");

                    b.ToTable("Orden");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Perfil", b =>
                {
                    b.Property<string>("IdPerfil")
                        .HasColumnName("idPerfil")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<decimal>("Costo")
                        .HasColumnName("costo")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdPerfil");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.PerfilExamen", b =>
                {
                    b.Property<string>("IdPerfilExamen")
                        .HasColumnName("idPerfilExamen")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("IdExamen")
                        .IsRequired()
                        .HasColumnName("idExamen")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("IdPerfil")
                        .IsRequired()
                        .HasColumnName("idPerfil")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("NombreExamen")
                        .IsRequired()
                        .HasColumnName("nombreExamen")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdPerfilExamen");

                    b.HasIndex("IdExamen");

                    b.HasIndex("IdPerfil");

                    b.ToTable("PerfilExamen");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Resultado", b =>
                {
                    b.Property<string>("IdResultado")
                        .HasColumnName("idResultado")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("IdDetalleOrden")
                        .IsRequired()
                        .HasColumnName("idDetalleOrden")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("IdExamen")
                        .IsRequired()
                        .HasColumnName("idExamen")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("NombreResultado")
                        .IsRequired()
                        .HasColumnName("NombreResultado")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdResultado");

                    b.HasIndex("IdDetalleOrden");

                    b.HasIndex("IdExamen");

                    b.ToTable("Resultado");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Usuario", b =>
                {
                    b.Property<string>("IdUsuario")
                        .HasColumnName("idUsuario")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnName("contraseña")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnName("NombreUsuario")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Clisoft.Domain.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Cliente")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FKClienteUSuario")
                        .IsRequired();
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.DetalleOrden", b =>
                {
                    b.HasOne("Clisoft.Domain.Entities.Orden", "IdOrdenNavigation")
                        .WithMany("DetalleOrden")
                        .HasForeignKey("IdOrden")
                        .HasConstraintName("FKDetalleOrdenOrden")
                        .IsRequired();

                    b.HasOne("Clisoft.Domain.Entities.Perfil", "IdPerfilNavigation")
                        .WithMany("DetalleOrden")
                        .HasForeignKey("IdPerfil")
                        .HasConstraintName("FKDetalleOrdenPerfil")
                        .IsRequired();
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Empleado", b =>
                {
                    b.HasOne("Clisoft.Domain.Entities.Cargo", "IdCargoNavigation")
                        .WithMany("Empleado")
                        .HasForeignKey("IdCargo")
                        .HasConstraintName("FKEmpleadoCargo")
                        .IsRequired();

                    b.HasOne("Clisoft.Domain.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("Empleado")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FKEmpleadoUsuario")
                        .IsRequired();
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Mascota", b =>
                {
                    b.HasOne("Clisoft.Domain.Entities.Cliente", "IdClienteNavigation")
                        .WithMany("Mascota")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FKMascotaCliente")
                        .IsRequired();
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Orden", b =>
                {
                    b.HasOne("Clisoft.Domain.Entities.Cliente", "IdClienteNavigation")
                        .WithMany("Orden")
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("FKOrdenCliente")
                        .IsRequired();

                    b.HasOne("Clisoft.Domain.Entities.Empleado", "IdEmpleadoNavigation")
                        .WithMany("Orden")
                        .HasForeignKey("IdEmpleado")
                        .HasConstraintName("FKOrdenEmpleado")
                        .IsRequired();
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.PerfilExamen", b =>
                {
                    b.HasOne("Clisoft.Domain.Entities.Examen", "IdExamenNavigation")
                        .WithMany("PerfilExamen")
                        .HasForeignKey("IdExamen")
                        .HasConstraintName("FKPerfilExamenExamen")
                        .IsRequired();

                    b.HasOne("Clisoft.Domain.Entities.Perfil", "IdPerfilNavigation")
                        .WithMany("PerfilExamen")
                        .HasForeignKey("IdPerfil")
                        .HasConstraintName("FKPerfilExamenPerfil")
                        .IsRequired();
                });

            modelBuilder.Entity("Clisoft.Domain.Entities.Resultado", b =>
                {
                    b.HasOne("Clisoft.Domain.Entities.DetalleOrden", "IdDetalleOrdenNavigation")
                        .WithMany("Resultado")
                        .HasForeignKey("IdDetalleOrden")
                        .HasConstraintName("FKResultadoDetalleOrden")
                        .IsRequired();

                    b.HasOne("Clisoft.Domain.Entities.Examen", "IdExamenNavigation")
                        .WithMany("Resultado")
                        .HasForeignKey("IdExamen")
                        .HasConstraintName("FKResultadoExamen")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
