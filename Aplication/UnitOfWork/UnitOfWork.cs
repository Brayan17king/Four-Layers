using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly FourLayersContext _context;
        private IRefreshToken _RefreshTokens;
        private IRolRepository _Roles;
        private IUserRepository _Users;

        public UnitOfWork(FourLayersContext context)
        {
            _context = context;
        }

        public IRefreshToken RefreshTokens
        {
            get
            {
                if (_RefreshTokens == null)
                {
                    _RefreshTokens = new RefreshTokenRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _RefreshTokens;
            }
        }

        public IRolRepository Roles
        {
            get
            {
                if (_Roles == null)
                {
                    _Roles = new RolRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Roles;
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_Users == null)
                {
                    _Users = new UserRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Users;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}