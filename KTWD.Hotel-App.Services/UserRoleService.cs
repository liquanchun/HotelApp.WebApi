using KTWD.Hotel_App.Models;
using KTWD.Hotel_App.Models.SYS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace KTWD.Hotel_App.Services
{
    public class UserRoleService
    {
        private HotelContext DbContext { get; set; }
        public UserRoleService(HotelContext dbContext)
        {
            DbContext = dbContext;
        }
        public List<sys_role> GetRoleList()
        {
            return DbContext.SysRole.ToList();
        }
        public sys_role AddRole(sys_role role)
        {
            try
            {
                if(DbContext.SysRole.Where(f => f.role_name == role.role_name).Count() > 0)
                {
                    throw new Exception("该用户角色名称已经存在。");
                }
                role.createdAt = DateTime.Now;
               var d = DbContext.SysRole.Add(role);
                DbContext.SaveChanges();
                return role;
            }
            catch(Exception ex)
            {
                throw ex;
            }
         }
        public sys_role GetRoleById(int roleId)
        {
           return  DbContext.SysRole.Find(roleId);
        }

        public string DeleteRole(int roleId)
        {
            if(DbContext.SysRoleUsers.Where(f => f.role_id == roleId).Count() > 0)
            {
                return "该角色存在关联用户，不能删除。";
            }
            if (DbContext.SysRoleMenus.Where(f => f.role_id == roleId).Count() > 0)
            {
                return "该角色存在关联菜单，不能删除。";
            }
            if (DbContext.SysRoleFunctions.Where(f => f.role_id == roleId).Count() > 0)
            {
                return "该角色存在关联功能，不能删除。";
            }
            var role = DbContext.SysRole.Find(roleId);
            if (role != null)
            {
                try
                {
                    DbContext.SysRole.Remove(role);
                    DbContext.SaveChanges();
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
            }
            return string.Empty;
        }

        public List<sys_user> GetUserList()
        {
            return DbContext.SysUsers.ToList();
        }

        public sys_user GetUserById(string userId)
        {
            return DbContext.SysUsers.Find(userId);
        }
        public string AddUser(sys_user user)
        {
            user.createdAt = DateTime.Now;
            try
            {
                var d = DbContext.SysUsers.Add(user);
                DbContext.SaveChanges();

                if (!string.IsNullOrEmpty(user.roleids) && user.roleids.Length > 1)
                {
                    //新增用户角色关系表
                    string[] roles = user.roleids.Split(",".ToArray());
                    foreach (var item in roles)
                    {
                        var userrole = new sys_role_user { role_id = int.Parse(item), user_id = user.user_id };
                        DbContext.SysRoleUsers.Add(userrole);
                    }
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }
        public string UpdateUser(string userId, sys_user user)
        {
            user.updatedAt = DateTime.Now;
            try
            {
                user.user_id = userId;
                var oldUser = GetUserById(userId);
                if(oldUser.roleids != user.roleids)
                {
                    //修改了用户角色
                    DbContext.RemoveRange(DbContext.SysRoleUsers.Where(f => f.user_id == userId));
                    DbContext.SaveChanges();
                    //新增用户角色关系表
                    string[] roles = user.roleids.Split(",".ToArray());
                    foreach (var item in roles)
                    {
                        var userrole = new sys_role_user { role_id = int.Parse(item), user_id = user.user_id };
                        DbContext.SysRoleUsers.Add(userrole);
                    }
                    DbContext.SaveChanges();
                }
                DbContext.SysUsers.Update(user);
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return string.Empty;
        }
    }
}
