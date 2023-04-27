using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class post
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [ForeignKey("user")]
        public string posted_by { get; set; }
      
        public DateTime  data { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<comment> comments { get; set; }

        public post()
        {
            comments = new List<comment>();
        }

    }
}
