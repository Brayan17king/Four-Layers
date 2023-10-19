using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRolEntity : BaseEntity
    {
        public int UsuarioId { get; set; }
        public UserEntity Usuario { get; set; }
        public int RolId { get; set; }
        public RolEntity Roles { get; set; }
        
    }
}