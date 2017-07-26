using KTWD.Hotel_App.Models.SYS;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
using System;

namespace KTWD.Hotel_App.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options)
        {

        }
        public DbSet<sys_user> SysUsers { get; set; }
        //public DbSet<sys_function> SysFunctions { get; set; }
        //public DbSet<sys_menu> SysMenus { get; set; }
        //public DbSet<sys_org> SysOrgs { get; set; }
        public DbSet<sys_role> SysRole { get; set; }

        public DbSet<sys_role_function> SysRoleFunctions { get; set; }
        public DbSet<sys_role_menu> SysRoleMenus { get; set; }
        public DbSet<sys_role_user> SysRoleUsers { get; set; }
        public DbSet<user_access_log> UserAccessLogs { get; set; }
        //public DbSet<user_login_log> UserLoginLogs { get; set; }
    }
}
