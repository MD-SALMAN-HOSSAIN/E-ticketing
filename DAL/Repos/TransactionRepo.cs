using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TransactionRepo :Repo Transaction, Irepo<Transaction, int, bool>
    {
        public bool Creat(Transaction obj)
        {
            db.t.Add(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> Read()
        {
             return db.Transactions.ToList();
        }

        public Transaction Read(int id)
        {
            return db.Transactions.Find(id);
        }

        public bool Update(Transaction obj)
        {
            throw new NotImplementedException();
        }
    }
}
