using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public List<PostDto>? Posts { get; set; }
    }
}
