using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Transaction
    {
        [Key]
        public int trans_ID { get; set; }
        [Required]
        [StringLength(25)]
        public string trans_name { get; set; }
        public DateTime trans_date { get; set; }
        [ForeignKey("Ticket")]
        public int ticket_ID { get; set; }
        [ForeignKey("Booking")]
        public int res_ID { get; set; }
       /* [ForeignKey("User")]
        public int user_ID { get; set; }*/
        
        public virtual Ticket Ticket { get; set; }
 
        public virtual Booking Booking { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }

        public virtual ICollection<Report> Reports { get; set; }

        public Transaction()
        {
            Admins = new List<Admin>();
            Reports = new List<Report>();
        }
    }
}
