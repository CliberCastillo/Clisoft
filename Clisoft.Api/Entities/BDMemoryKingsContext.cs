using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Clisoft.Api.Entities
{
    public partial class BDMemoryKingsContext : DbContext
    {
        public BDMemoryKingsContext()
        {
        }

        public BDMemoryKingsContext(DbContextOptions<BDMemoryKingsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Compras> Compras { get; set; }
        public virtual DbSet<DetalleCompras> DetalleCompras { get; set; }
        public virtual DbSet<Domicilio> Domicilio { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<MetodoPago> MetodoPago { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-30N757O;Database=BDMemoryKings;User ID = cliber;Password=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240CF3333907");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("idCategoria")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasColumnName("foto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Compras>(entity =>
            {
                entity.HasKey(e => e.IdCompras)
                    .HasName("PK__Compras__BEF65317F4A0E845");

                entity.Property(e => e.IdCompras)
                    .HasColumnName("idCompras")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompras)
                    .HasColumnName("fechaCompras")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdPago)
                    .HasColumnName("idPago")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(4, 1)");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.IdPago)
                    .HasConstraintName("FK__Compras__idPago__59063A47");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Compras)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Compras__idUsuar__656C112C");
            });

            modelBuilder.Entity<DetalleCompras>(entity =>
            {
                entity.HasKey(e => e.IdDetalle)
                    .HasName("PK__DetalleC__49CAE2FBD53C7923");

                entity.Property(e => e.IdDetalle)
                    .HasColumnName("idDetalle")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.IdCompras).HasColumnName("idCompras");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("idProducto")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioCompra)
                    .HasColumnName("precioCompra")
                    .HasColumnType("decimal(4, 1)");

                entity.HasOne(d => d.IdComprasNavigation)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.IdCompras)
                    .HasConstraintName("FK__DetalleCo__idCom__60A75C0F");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK__DetalleCo__idPro__5FB337D6");
            });

            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.HasKey(e => e.IdDomicilio)
                    .HasName("PK__Domicili__7F6CE3D9ABB5B94D");

                entity.Property(e => e.IdDomicilio)
                    .HasColumnName("idDomicilio")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasColumnName("ciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .IsRequired()
                    .HasColumnName("codigoPostal")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasColumnName("departamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Distrito)
                    .IsRequired()
                    .HasColumnName("distrito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasColumnName("provincia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Domicilio)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Domicilio__idUsu__6477ECF3");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK__Marca__703318125161BB6D");

                entity.Property(e => e.IdMarca)
                    .HasColumnName("idMarca")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("PK__MetodoPa__BD2295ADB960FC55");

                entity.Property(e => e.IdPago)
                    .HasColumnName("idPago")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__Producto__07F4A132FAA76A7E");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("idProducto")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Foto)
                    .HasColumnName("foto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("idCategoria")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdMarca)
                    .HasColumnName("idMarca")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(5, 1)");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Producto__idCate__4E88ABD4");

                entity.HasOne(d => d.IdMarcaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdMarca)
                    .HasConstraintName("FK__Producto__idMarc__70DDC3D8");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__Rol__3C872F76800DAA62");

                entity.Property(e => e.IdRol)
                    .HasColumnName("idRol")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A6DE64E369");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasColumnName("apellidoMaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnName("apellidoPaterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasColumnName("contraseña")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasColumnName("genero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRol)
                    .IsRequired()
                    .HasColumnName("idRol")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Usuario__idRol__6383C8BA");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
