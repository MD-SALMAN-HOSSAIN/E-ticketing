using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class dbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Bookings> bookings { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Transaction> transactions { get; set; }

        public DbSet<ticket> Tickets { get; set; }
        public DbSet<Token> Tokens { get; set; }

        public DbSet<post> posts { get; set; }
        
    }
}
