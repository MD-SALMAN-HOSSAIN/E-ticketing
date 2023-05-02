using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ReportRepo : Report, Irepo<Report, int, bool>
    {
        public bool Creat(Report obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Report> Read()
        {
            throw new NotImplementedException();
        }

        public Report Read(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Report obj)
        {
            throw new NotImplementedException();
        }
    }
}
