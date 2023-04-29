using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class TicketDTO
    {
        public int TId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int EventId { get; set; }

        public DateTime PurchaseDate { get; set; }

        [Required]
        public float Price { get; set; }

        public string Destinetations { get; set; }
    }
}
