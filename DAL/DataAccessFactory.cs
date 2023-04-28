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
        public static Irepo<comment, int, bool> CommentData()
        {
            return new commentRepo();
        }

        public static Irepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
      /*  public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }*/
       /* public static Irepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }*/
    }
}
