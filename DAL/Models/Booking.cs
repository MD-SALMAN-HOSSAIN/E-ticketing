/*using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Booking
    {
        [Key]
        public int Booking_ID { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; }
        [ForeignKey("Ticket")]
        public int Ticket_ID { get; set; }
        [Required]
        public DateTime booking_Date { get; set; }
        [Required]
        public int payment { get; set; }

        public virtual User User { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

        public Booking()
        {
           
            Transactions = new List<Transaction>();
        }
    }
}
*/