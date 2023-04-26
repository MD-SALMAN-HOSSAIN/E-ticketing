using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Manager
    {
        

        public string uId { get; set; }

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
