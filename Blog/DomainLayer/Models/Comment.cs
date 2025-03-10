using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Comment : BaseModel
    {
        public string Content { get; set; }

        // Foreign Key for BlogPost
        public int PostId { get; set; }
        public Post Post { get; set; }

        // Foreign Key for User (Author)
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
