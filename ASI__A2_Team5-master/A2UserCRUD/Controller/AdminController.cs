using A2UserCRUD.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private ILogger _logger;
        private IAdminsService _service;


        public AdminController(ILogger<AdminController> logger, IAdminsService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/Admin")]
        public ActionResult<List<Admin>> GetAdmins()
        {
            return _service.GetAdmins();
        }

        [HttpPost("/api/Admin")]
        public ActionResult<Admin> AddAdmin([FromBody]Admin admin)
        {
            _service.AddAdmin(admin);
            return admin;
        }

        [HttpPut("/api/admin/{id}")]
        public ActionResult<Admin> UpdateAdmin(string id, [FromBody]Admin admin)
        {
            _service.UpdateAdmin(id, admin);
            return admin;
        }

        [HttpDelete("/api/admin/{id}")]
        public ActionResult<string> DeleteAdmin(string id)
        {
            _service.DeleteAdmin(id);
            return id;
        }
    }
}