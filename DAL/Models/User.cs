using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int uID { get; set; }
        [Required]
        [StringLength(30)]

        public string uName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }


        public virtual ICollection<Ticket> Tickets { get; set; }

        public User()
        {
            Tickets = new List<Ticket>();
            Bookings = new List<Booking>();

        }



    }
}
