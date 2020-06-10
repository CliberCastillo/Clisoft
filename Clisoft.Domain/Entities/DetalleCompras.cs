namespace Clisoft.Domain.Entities
{
    public partial class DetalleCompras
    {
        public string IdDetalle { get; set; }
        public string IdProducto { get; set; }
        public int? IdCompras { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioCompra { get; set; }

        public virtual Compras IdComprasNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
