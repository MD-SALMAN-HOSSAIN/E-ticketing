using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ticket
    {
        [Key]
        public int TId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int EventId { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public float Price { get; set; }

        public string Destinetations { get; set; }

        [ForeignKey("User")]
        public int posted_by { get; set; }

        public virtual User User { get; set; }

    }
}
