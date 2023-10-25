using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data;

public class FourLayersContext : DbContext
{
    public FourLayersContext(DbContextOptions<FourLayersContext> options) : base(options)
    {
    }

    public DbSet<RolEntity> Roles { get; set; }
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserRolEntity> UserRoles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

