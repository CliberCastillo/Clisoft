﻿using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class ExamenRepository : GenericRepository<Examen>, IExamenRepository
    {

        private readonly ClisoftContext _context;

        public ExamenRepository(ClisoftContext context) : base(context)
        {
            _context = context;
        }
    }
}
