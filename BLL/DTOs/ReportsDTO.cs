using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    class ReportsDTO
    {
        
        public int ReportId { get; set; }

        public DateTime Report_date { get; set; }
        [Required]
        public string Income { get; set; }
        [Required]
        public string Expense { get; set; }
        
        public int T_ID { get; set; }
    }
}
