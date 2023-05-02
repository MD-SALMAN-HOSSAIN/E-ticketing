using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
<<<<<<< HEAD
    internal class TicketRepo :Repo, Irepo<Ticket, int, bool>
=======
    internal class TicketRepo : Repo, Irepo<Ticket, int, bool>
>>>>>>> 8d0b4bf4be66c4932fdbdcc61b790d1bd5dd73f8
    {
        public bool Creat(Ticket obj)
        {

            db.Tickets.Add(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Tickets.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Ticket> Read()
        {
            return db.Tickets.ToList();
        }

        public Ticket Read(int id)
        {
            return db.Tickets.Find(id);
        }

        public bool Update(Ticket obj)
        {
            var ex = Read(obj.TId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }
    }
}
