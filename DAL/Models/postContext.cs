using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class postContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<post> post { get; set; }

        public DbSet<comment> comments{ get; set;}
    }
}
