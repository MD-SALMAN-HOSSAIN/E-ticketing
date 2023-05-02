using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.services
{
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {

            var data = DataAccessFactory.AdminData().Get();
            return Convert(data);

        }
        public static List<AdminDTO> Get10()
        {
            var admin = DataAccessFactory.AdminData().Get();
            var data = (from e in admin
                        where e.Id < 11
                        select e).ToList();
            return Convert(data);
        }
        public static AdminDTO Get(int id)
        {
            return Convert(DataAccessFactory.AdminData().Get(id));
        }
        public static bool Create(AdminDTO admin)
        {
            var data = Convert(admin);
            var res = DataAccessFactory.AdminData().Insert(data);

            if (res != null) return true;
            return false;
        }
        public static bool Update(AdminDTO admin)
        {
            var data = Convert(admin);
            var res = DataAccessFactory.AdminData().Update(data);

            if (res != null) return true;
            return false;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.AdminData().Delete(id);
        }

        static List<AdminDTO> Convert(List<Admin> admins)
        {
            var data = new List<AdminDTO>();
            foreach (var admin in admins)
            {
                data.Add(Convert(admin));
            }
            return data;

        }
        static Admin Convert(AdminDTO admin)
        {
            return new Admin()
            {
                AdminId = admin.AdminId,
                Uname = admin.Uname,
                Password = admin.Password,
                Gender = admin.Gender,
                Age = admin.Age,
                Email = admin.Email,
                T_ID = admin.T_ID
            };
        }
        static AdminDTO Convert(AdminDTO admin)
        {
            return new AdminDTO()
            {
                AdminId = admin.AdminId,
                Uname = admin.Uname,
                Password = admin.Password,
                Gender = admin.Gender,
                Age = admin.Age,
                Email = admin.Email,
                T_ID = admin.T_ID
            };
        }
        /*public static object AdminRepo { get; private set; }

        public static List<AdminDTO> Get()
        {
            var data = AdminRepo.Get();
            return Convert(data);

        }
        public static List<AdminDTO> Get10()
        {
            var data = (from n in AdminRepo.Get()
                        where n.Id < 11
                        select n).ToList();
            return Convert(data);
        }
        public static AdminDTO Get(int id)
        {
            return Convert(AdminRepo.Get(id));
        }
        public static bool Create(AdminDTO admin)
        {
            var data = Convert(admin);
            return AdminRepo.Create(data);
        }
        public static bool Update(AdminDTO admin)
        {
            var data = Convert(admin);
            return AdminRepo.Update(data);
        }
        public static bool Delete(int id)
        {
            return AdminRepo.Delete(id);
        }

        static List<AdminDTO> Convert(List<Admin> admins)
        {
            var data = new List<AdminDTO>();
            foreach (var admin in admins)
            {
                data.Add(new AdminDTO()
                {
                    AdminId = admin.AdminId,
                    Uname = admin.Uname,
                    Password = admin.Password,
                    Gender = admin.Gender,
                    Age = admin.Age,
                    Email = admin.Email,
                    T_ID = admin.T_ID

                });
            }
            return data;

        }
        static Admin Convert(AdminDTO admin)
        {
            return new Admin()
            {
                AdminId = admin.AdminId,
                Uname = admin.Uname,
                Password = admin.Password,
                Gender = admin.Gender,
                Age = admin.Age,
                Email = admin.Email,
                T_ID = admin.T_ID
            };
        }
        static AdminDTO Convert(Admin admin)
        {
            return new AdminDTO()
            {
                AdminId = admin.AdminId,
                Uname = admin.Uname,
                Password = admin.Password,
                Gender = admin.Gender,
                Age = admin.Age,
                Email = admin.Email,
                T_ID = admin.T_ID
            };
        }*/
    }
}
