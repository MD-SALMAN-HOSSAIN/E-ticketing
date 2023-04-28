using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{

    internal class UserRepo : Repo, Irepo<User, String, User>
    {
        /* public bool Authenticate(string username, string password)
         * 
         * , IAuth<bool>
         {
             var data = db.Users.FirstOrDefault(u => u.Uname.Equals(username) && password.Equals(password));
             if (data != null) return true;
             return false;
         }*/

        public User Creat(User obj)
        {
            db.Users.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Users.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<User> Read()
        {
            return db.Users.ToList();
        }

        public User Read(string id)
        {
            return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var ex = Read(obj.uName);
            db.Entry(ex).CurrentValues.SetValues (obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }

}
