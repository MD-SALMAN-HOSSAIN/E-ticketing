/*using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PostRepo : Repo, Irepo<Post, int, bool>
    {
        public bool Creat(Post obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> Read()
        {
            return db.posts.ToList();
        }

        public Post Read(int id)
        {
            return db.posts.Find(id);
        }

        public bool Update(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}
*/