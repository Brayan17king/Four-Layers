using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<RolEntity> Roles { get; set; } = new HashSet<RolEntity>();
        public ICollection<RefreshTokenEntity> RefreshTokens { get; set; } = new HashSet<RefreshTokenEntity>();
        public ICollection<UserRolEntity> UserRoles { get; set; } = new HashSet<UserRolEntity>();

    }
}