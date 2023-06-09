﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Comment
    {
        public int id { get; set; }
        [Required]
        public string commentText { get; set; }
        [Required]

        public DateTime Time { get; set; }
        [ForeignKey("User")]
        public string commentBy { get; set; }

        [ForeignKey("Post")]
        public string postId { get; set; }

        public virtual Post Post { get; set; }

        public virtual User User { get; set; }


    }
}
