using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RolEntity : BaseEntity
    {
        public string NombreRol { get; set; }
        public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
        public ICollection<UserRolEntity> UserRoles { get; set; }
    }
}