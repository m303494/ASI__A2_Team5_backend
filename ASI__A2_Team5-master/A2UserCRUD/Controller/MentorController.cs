﻿using A2UserCRUD.Services;
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
    public class MentorController : ControllerBase
    {

        private ILogger _logger;
        private IMentorService _service;


        public MentorController(ILogger<MentorController> logger, IMentorService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/mentor")]
        public ActionResult<List<Mentor>> GetMentors()
        {
            return _service.GetMentors();
        }

        [HttpPost("/api/mentor")]
        public ActionResult<Mentor> AddMentor([FromBody]Mentor mentor)
        {
            _service.AddMentor(mentor);
            return mentor;
        }

        [HttpPut("/api/mentor/{id}")]
        public ActionResult<Mentor> UpdateMentor(string id, [FromBody]Mentor mentor)
        {
            _service.UpdateMentor(id, mentor);
            return mentor;
        }

        [HttpDelete("/api/mentor/{id}")]
        public ActionResult<string> DeleteMentor(string id)
        {
            _service.DeleteMentor(id);
            return id;
        }
    }
}
