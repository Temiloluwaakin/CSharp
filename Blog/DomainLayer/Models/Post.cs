using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DomainLayer.Models
{
    public class Post : BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsPublished { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }

        // Comments
        public List<Comment> Comments { get; set; }
    }
}
