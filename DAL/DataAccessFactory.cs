using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static Irepo<post, int, bool> PostData()
        {
            return new PostRepo();
        }
        public static Irepo<Comment, int, bool> CommentData()
        {
            return new CommentRepo();
        }

        public static Irepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
    }
}
