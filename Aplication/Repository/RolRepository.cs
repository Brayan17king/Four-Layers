using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository
{
    public class RolRepository : GenericRepository<RolEntity>, IRolRepository
    {
        private readonly FourLayersContext _context;

        public RolRepository(FourLayersContext context) : base(context)
        {
            _context = context;
        }
    }
}