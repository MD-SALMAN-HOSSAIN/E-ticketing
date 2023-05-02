﻿using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TicketRepo :Repo, Irepo<Ticket, int, bool>
    {
        public bool Creat(Ticket obj)
        {
            db.Bookings.Add(obj);
            if (db.SaveChanges() > 0) ;
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
