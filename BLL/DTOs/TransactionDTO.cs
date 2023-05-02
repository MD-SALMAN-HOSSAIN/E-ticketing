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
    internal class TransactionDTO
    {
        public int trans_ID { get; set; }
        [Required]
        public string trans_name { get; set; }
        public DateTime trans_date { get; set; }

        public int ticket_ID { get; set; }
     
        public int res_ID { get; set; }
        
        public int user_ID { get; set; }

        public int admin_ID { get; set; }
        

       
    }
}
