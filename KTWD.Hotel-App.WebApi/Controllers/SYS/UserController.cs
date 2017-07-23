using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KTWD.Hotel_App.Models;
using KTWD.Hotel_App.Services;
using KTWD.Hotel_App.Models.SYS;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Cors;

namespace KTWD.Hotel_App.WebApi.Controllers.SYS
{
    [EnableCors("AllowWebApp")]
    [Produces("application/json")]
    [Route("api/Users")]
    public class UserController : Controller
    {
        private UserRoleService _SysRoleService = null;
        public UserController(HotelContext dbContext)
        {
            _SysRoleService =  new UserRoleService(dbContext) ;
        }
        // GET: api/Roles
        [HttpGet]
        public IEnumerable<sys_user> Get()
        {
            return _SysRoleService.GetUserList();
        }

        // GET: api/Roles/5
        [HttpGet("{id}", Name = "GetUserById")]
        public sys_user Get(string id)
        {
            return _SysRoleService.GetUserById(id);
        }
        
        // POST: api/Roles
        [HttpPost]
        public async Task Post([FromBody]sys_user user)
        {
            var result = _SysRoleService.AddUser(user);
            var data = Encoding.UTF8.GetBytes(result);
            await Response.Body.WriteAsync(data, 0, data.Length);
        }
        
        // PUT: api/Roles/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody]sys_user user)
        {
            var result = _SysRoleService.UpdateUser(id, user);
            var data = Encoding.UTF8.GetBytes(result);
            await Response.Body.WriteAsync(data, 0, data.Length);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
