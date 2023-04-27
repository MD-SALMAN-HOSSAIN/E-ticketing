using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class commentRepo : Repo, Irepo<comment, int, bool>
    {
        public bool Creat(comment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<comment> Read()
        {
            throw new NotImplementedException();
        }

        public comment Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(comment obj)
        {
            throw new NotImplementedException();
        }
    }
}
