using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A2UserCRUD.Services;
using Microsoft.AspNetCore.Mvc;

namespace A2UserCRUD.Controller
{
    public class MessagesController
    {
        private IMessagesService _service;

        public MessagesController(IMessagesService service)
        {
            _service = service;
        }

        [HttpGet("/api/messages")]
        public ActionResult<List<Messages>> GetMessages()
        {
            return _service.GetMessages();
        }

        [HttpPost("/api/messages")]
        public ActionResult<Messages> AddMessages([FromBody]Messages message)
        {
            _service.AddMessages(message);
            return message;
        }

        [HttpPut("/api/messages/{id}")]
        public ActionResult<Messages> UpdateMessages(String id, [FromBody]Messages message)
        {
            _service.UpdateMessages(id, message);
            return message;
        }

        [HttpDelete("/api/messages/{id}")]
        public ActionResult<String> DeleteMessages(String id)
        {
            _service.DeleteMessages(id);
            return id;
        }

    }
}
