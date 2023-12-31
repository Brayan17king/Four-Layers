using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class DataUserDto
    {
        public string Message { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public string Token { get; set; }

        [JsonIgnore] // -> this atribute restricts the properties to be shown in the results
        public string  RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}