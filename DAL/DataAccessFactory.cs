﻿using DAL.Interfaces;
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
        /*public static Irepo<Post, int, bool> PostData()
        {
            return new PostRepo();
        }*/
        public static Irepo<Admin, int, bool> admindata()
        {
            return new AdminRepo();
        }

        public static Irepo<Booking, int, bool> Bookingdata()
        {
            return new BookingRepo();
        }
        public static Irepo<Ticket, int, bool> Ticket()
        {
            return new TicketRepo();
        }
        public static Irepo<Transaction, int, bool> Transaction()
        {
            return new TransactionRepo();
        }

        public static Irepo<Comment, int, bool> CommentData()
        {
            return new commentRepo();
        }

        public static Irepo<User, string, User> UserData()
        {
            return new UserRepo();
        }


      /*  ata aktu  sob gular jonno koiro  as models 
       * 
       * 
       * public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }
        public static Irepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }*/
    }
}
