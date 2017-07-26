using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using KTWD.Hotel_App.Models.SYS;
using KTWD.Hotel_App.Models;

namespace KTWD.Hotel_App.WebApi.Controllers
{
    [EnableCors("AllowWebApp")]
    [Produces("application/json")]
    [Route("api/Common")]
    public class CommonController : Controller
    {
        private HotelContext _HotelContext = null;
        public CommonController(HotelContext dbContext)
        {
            _HotelContext = dbContext;
        }
        // GET: api/Common
        [Route("log")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Common
        [Route("log")]
        [HttpPost]
        public void Post([FromBody]user_access_log log)
        {
            log.createdAt = DateTime.Now;
            _HotelContext.UserAccessLogs.Add(log);
            _HotelContext.SaveChangesAsync();
        }
        
        // PUT: api/Common/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
