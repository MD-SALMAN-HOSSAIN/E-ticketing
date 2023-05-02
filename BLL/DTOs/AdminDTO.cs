using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class AdminDTO
    {
        
        public int AdminId { get; set; }
        [Required]
       
        public string Uname { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string T_ID { get; set; }

    }
}
