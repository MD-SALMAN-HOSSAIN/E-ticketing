using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Transaction
    {
        [Key]
        public int trans_ID { get; set; }
        [Required]
        [StringLength(25)]
        public string trans_name { get; set; }
        [ForeignKey("ticket")]
        public int ticket_ID { get; set; }
        [ForeignKey("bookings")]
        public int res_ID { get; set; }
        [ForeignKey("User")]
        public int user_ID { get; set; }
        [ForeignKey("admin")]
        public int admin_ID { get; set; }
        public virtual ticket ticket { get; set; }
        public virtual Admin admin { get; set; }
        public virtual Bookings bookings { get; set; }
        public virtual User user { get; set; }
    }
}
