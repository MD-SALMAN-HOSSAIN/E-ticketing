using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminRepo : Repo, Irepo<Admin, int, bool>
    {
        public bool Creat(Admin obj)
        {
            
            db.Admins.Add(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Admins.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Admin> Read()
        {
            return db.Admins.ToList();
        }

        public Admin Read(int id)
        {
            return db.Admins.Find(id);
        }

        public bool Update(Admin obj)
        {
           var ex = Read(obj.AdminId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }
    }
}
