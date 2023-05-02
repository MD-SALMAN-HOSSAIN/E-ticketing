using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Manager
    {

        [Key]
        public string uId { get; set; }
        
        [Required]
        [Key]
        public string mId { get; set; }

        [Required]
        [StringLength(50)]
        public string uName { get; set; }

        [Required]
        [StringLength(50)]
        public string movie { get; set; }

        [Required]
        public DateTime movie_time { get; set; }


    }
}
