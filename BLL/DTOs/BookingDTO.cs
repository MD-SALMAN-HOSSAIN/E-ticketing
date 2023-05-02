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
    public class BookingDTO
    {
        
        public int booking_ID { get; set; }

        [Required]
        public int user_ID { get; set; }

        [Required]
        public int ticket_ID { get; set; }

        public DateTime booking_Date { get; set; }

        public int payment { get; set; }

        public virtual User user { get; set; }

        public virtual Ticket ticket { get; set; }

    }
}
