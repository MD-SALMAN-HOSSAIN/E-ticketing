using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{


    internal class TransactionRepo :Repo,  Irepo<Transaction, int, bool>

    {
        public bool Creat(Transaction obj)
        {
            {

                db.transactions.Add(obj);
                if (db.SaveChanges() > 0) ;
                return false;
            }
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.transactions.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Transaction> Read()
        {
             return db.transactions.ToList();

           

        }

        public Transaction Read(int id)
        {
            return db.transactions.Find(id);
        }

        public bool Update(Transaction obj)
        {
            var ex = Read(obj.trans_ID);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }
    }
}
