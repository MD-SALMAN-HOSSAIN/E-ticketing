using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    class AuthService
    {
        public static bool Authenticate(string uname, string pass)
        {
            var res= DataAccessFactory.AuthData().Authenticate( uname , pass);
            if(res)
            {
                var token = new Token();
                token.UserId = uname;
                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().ToString(token);
                if(ret !=null)

            }
        }
    }
}
