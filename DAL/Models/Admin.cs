using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    class Admin
    {
        [Key]
       public string Uname { get; set; }
        [Required]
        [StringLength(30)]
       public string Password { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }


    }
}
