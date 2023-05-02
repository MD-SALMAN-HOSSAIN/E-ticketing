/*using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookingRepo :Repo,Irepo<Booking, int, bool>
    {
        public bool Creat(Booking obj)
        {
            db.Bookings.Add(obj);
            if (db.SaveChanges() > 0) ;
            return true;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Bookings.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Booking> Read()
        {
            return new List<Booking>();
        }

        public Booking Read(int id)
        {
            return db.Bookings.Find(id);
        }

        public bool Update(Booking obj)
        {
            var ex = Read(obj.Booking_ID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }
    }
}*/