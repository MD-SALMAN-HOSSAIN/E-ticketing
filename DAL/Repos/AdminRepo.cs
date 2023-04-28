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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
