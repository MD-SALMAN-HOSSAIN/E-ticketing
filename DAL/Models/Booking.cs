using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Bookings
    {
        [Key]
        public int booking_ID { get; set; }
        [ForeignKey("user")]
        public int user_ID { get; set; }
        [ForeignKey("ticket")]
        public int ticket_ID { get; set; }
        [Required]
        public DateTime booking_Date { get; set; }
        [Required]
        public int payment { get; set; }

        public virtual User user { get; set; }
        public virtual ticket ticket { get; set; }
        
    }
}
