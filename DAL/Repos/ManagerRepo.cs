using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManagerRepo : Repo, Irepo<Manager, int, bool>
    {
        public bool Creat(Manager obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Manager> Read()
        {
            return db.Managers.ToList();
        }

        public Manager Read(int id)
        {
            return db.Managers.Find(id);
        }

        public bool Update(Manager obj)
        {
            throw new NotImplementedException();
        }
    }
}
