using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        [StringLength(30)]
        public string Uname { get; set; }
        [Required]
        [StringLength(30)]
       public string Password { get; set; }
        [Required]
       public string Gender { get; set; }
        [Required]
       public string Age { get; set; }
       
        [Required]
        public string Email { get; set; }

        [ForeignKey("Transaction")]
        public int T_ID { get; set; }

        public virtual Transaction Transaction { get; set; }


    }
}
