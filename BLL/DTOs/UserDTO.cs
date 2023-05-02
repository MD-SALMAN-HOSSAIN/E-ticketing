using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public int uID { get; set; }
        [Required]
        
        public string uName { get; set; }
        [Required]
        
        public string Password { get; set; }
        [Required]
        
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public string Email { get; set; }



    }
}
