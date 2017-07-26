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
    [Route("api/Roles")]
    public class RolesController : Controller
    {
        private UserRoleService _SysRoleService = null;
        public RolesController(HotelContext dbContext)
        {
            _SysRoleService =  new UserRoleService(dbContext) ;
        }
        // GET: api/Roles
        [HttpGet]
        public IEnumerable<sys_role> Get()
        {
            return _SysRoleService.GetRoleList();
        }

        // GET: api/Roles/5
        [HttpGet("{id}", Name = "GetRoleById")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Roles
        [HttpPost]
        public sys_role Post([FromBody]sys_role role)
        {
            return _SysRoleService.AddRole(role);
        }
        
        // PUT: api/Roles/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var result = _SysRoleService.DeleteRole(id);
            var data = Encoding.UTF8.GetBytes(result);
            Response.Body.WriteAsync(data, 0, data.Length);
        }
    }
}
