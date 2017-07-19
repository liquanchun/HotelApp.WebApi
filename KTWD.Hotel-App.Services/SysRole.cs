using KTWD.Hotel_App.Models;
using KTWD.Hotel_App.Models.SYS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace KTWD.Hotel_App.Services
{
    public class SysRole
    {
        private HotelContext DbContext { get; set; }
        public SysRole(HotelContext dbContext)
        {
            DbContext = dbContext;
        }
        public List<sys_role> GetRoleList()
        {
            DbContext.SysRole.ToList();
            return null;
        }

        public sys_role GetRoleById()
        {
            return DbContext.SysRole.FirstOrDefault();
        }
    }
}
