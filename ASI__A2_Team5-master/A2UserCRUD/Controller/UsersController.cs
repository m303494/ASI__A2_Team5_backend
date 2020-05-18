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
    public class UsersController : ControllerBase
    {

        private ILogger _logger;
        private IUsersService _service;


        public UsersController(ILogger<UsersController> logger, IUsersService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/users")]
        public ActionResult<List<User>> GetUsers()
        {
            return _service.GetUsers();
        }

        [HttpPost("/api/users")]
        public ActionResult<User> AddUser([FromBody]User user)
        {
            _service.AddUser(user);
            return user;
        }

        [HttpPut("/api/users/{id}")]
        public ActionResult<User> UpdateProduct(string id, [FromBody]User user)
        {
            _service.UpdateUser(id, user);
            return user;
        }

        [HttpDelete("/api/users/{id}")]
        public ActionResult<string> DeleteUser(string id)
        {
            _service.DeleteUser(id);
            //_logger.LogInformation("products", _products);
            return id;
        }
    }
}
