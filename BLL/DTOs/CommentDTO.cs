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
    public class CommentDTO
    {
       
         public int id { get; set; }
        [Required]
        public string commentText { get; set; }
        

        public DateTime Time { get; set; }
        
        public string commentBy { get; set; }

        public string postId { get; set; }

      
    }
}
