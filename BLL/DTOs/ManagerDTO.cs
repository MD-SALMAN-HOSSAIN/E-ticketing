using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    internal class ManagerDTO
    {
        
        public string uId { get; set; }
        [Required]
        public string mId { get; set; }

        [Required]
        public string uName { get; set; }

        [Required]
        public string movie { get; set; }
        [Required]
        public DateTime movie_time { get; set; }

    }
}
