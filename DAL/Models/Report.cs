using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }

        public DateTime Report_date { get; set; }
        [Required]
        public string Income { get; set; }
        [Required]
        public string Expense { get; set; }
        [ForeignKey("Transaction")]
        public int T_ID { get; set; }

        public virtual Transaction Transaction { get; set; }
        
        /*[ForeignKey("Booking")]
        public int B_ID { get; set; }

        public virtual Booking Bookings { get; set; }
        */
    }
}
