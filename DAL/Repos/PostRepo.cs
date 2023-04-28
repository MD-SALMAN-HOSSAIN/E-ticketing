using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PostRepo : Repo, Irepo<post, int, bool>
    {
        public bool Creat(post obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<post> Read()
        {
            return db.posts.ToList();
        }

        public post Read(int id)
        {
            return db.posts.Find(id);
        }

        public bool Update(post obj)
        {
            throw new NotImplementedException();
        }
    }
}
