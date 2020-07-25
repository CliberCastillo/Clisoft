using Clisoft.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Components.Common.GenerarCodigo
{
    public class Usuario
    {
        private readonly ClisoftContext _context;

        public Usuario(ClisoftContext context)
        {
            _context = context;
        }
    }
}
