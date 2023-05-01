using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [ForeignKey("User")]
        public int posted_by { get; set; }
      
        public DateTime  data { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Comment> comments { get; set; }

        public Post()
        {
            comments = new List<Comment>();
        }

    }
}
