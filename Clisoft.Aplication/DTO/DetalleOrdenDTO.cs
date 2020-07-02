using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.DTO
{
    public class DetalleOrdenDTO
    {
        public string IdDetalleOrden { get; set; }
        public string IdPerfil { get; set; }
        public string IdOrden { get; set; }
        public decimal CostoServicio { get; set; }
    }
}
