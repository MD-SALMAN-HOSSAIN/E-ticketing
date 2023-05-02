using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class BookingDTO
    {
        
        public int Booking_ID { get; set; }

        [Required]
        public int User_ID { get; set; }

        [Required]
        public int Ticket_ID { get; set; }

        public DateTime booking_Date { get; set; }

        public int payment { get; set; }

        public virtual User user { get; set; }

        public virtual Ticket ticket { get; set; }

    }
}
