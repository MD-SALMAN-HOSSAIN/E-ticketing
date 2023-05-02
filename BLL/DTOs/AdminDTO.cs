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
<<<<<<< HEAD
        [Required]
        public string Age { get; set; }
        [Required]
=======

>>>>>>> b1be9af03368083c969a113eb42487806c30e52e
        public string Email { get; set; }
        [Required]
        public string T_ID { get; set; }

    }
}
