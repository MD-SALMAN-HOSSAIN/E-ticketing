using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReportRepo : Repo, Irepo<Report, int, bool>
    {
        public bool Creat(Report obj)
        {
            db.Reports.Add(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            db.Reports.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Report> Read()
        {
            return db.Reports.ToList();
        }

        public Report Read(int id)
        {
            return db.Reports.Find(id);
        }

        public bool Update(Report obj)
        {
            var ex = Read(obj.ReportId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) ;
            return false;
        }
    }
}
