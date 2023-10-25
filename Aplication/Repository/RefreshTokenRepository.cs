using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Aplication.Repository
{
    public class RefreshTokenRepository : GenericRepository<RefreshTokenEntity>, IRefreshToken
    {
        private readonly FourLayersContext _context;

        public RefreshTokenRepository(FourLayersContext context) : base(context)
        {
            _context = context;
        }
    }
}