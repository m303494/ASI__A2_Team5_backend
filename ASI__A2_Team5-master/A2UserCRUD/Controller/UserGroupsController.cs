using A2UserCRUD.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UserGroupsController : ControllerBase
    {

        private ILogger _logger;
        private IUserGroups _service;


        public UserGroupsController(ILogger<UserGroupsController> logger, IUserGroups service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/usergroups")]
        public ActionResult<List<UserGroups>> GetUserGroup()
        {
            return _service.GetUserGroups();
        }

        [HttpPost("/api/usergroups")]
        public ActionResult<UserGroups> AddUserGroup([FromBody]UserGroups UG)
        {
            _service.AddUserGroup(UG);
            return UG;
        }

        [HttpPut("/api/usergroups/{id}")]
        public ActionResult<UserGroups> UpdateUserGroup(string id, [FromBody]UserGroups UG)
        {
            _service.UpdateUserGroup(id, UG);
            return UG;
        }

        [HttpDelete("/api/usergroups/{id}")]
        public ActionResult<string> DeleteUserGroup(string id)
        {
            _service.DeleteUserGroup(id);
            return id;
        }
    }
}
