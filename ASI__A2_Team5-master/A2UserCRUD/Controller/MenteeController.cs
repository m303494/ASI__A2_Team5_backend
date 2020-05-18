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
    public class MenteeController : ControllerBase
    {

        private ILogger _logger;
        private IMenteeService _service;


        public MenteeController(ILogger<MenteeController> logger, IMenteeService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/mentee")]
        public ActionResult<List<Mentee>> GetMentees()
        {
            return _service.GetMentees();
        }

        [HttpPost("/api/mentee")]
        public ActionResult<Mentee> AddMentee([FromBody]Mentee mentee)
        {
            _service.AddMentee(mentee);
            return mentee;
        }

        [HttpPut("/api/mentee/{id}")]
        public ActionResult<Mentee> UpdateMentee(string id, [FromBody]Mentee mentee)
        {
            _service.UpdateMentee(id, mentee);
            return mentee;
        }

        [HttpDelete("/api/mentee/{id}")]
        public ActionResult<string> DeleteMentee(string id)
        {
            _service.DeleteMentee(id);
            return id;
        }
    }
}
