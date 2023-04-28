﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    interface IAuth<Ret>
    {
        Ret Authenticate(string username, string password);
        object Authenticate(string uname, string pass);
    }
}
