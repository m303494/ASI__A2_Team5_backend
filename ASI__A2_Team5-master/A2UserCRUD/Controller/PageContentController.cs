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
    public class PageContentController : ControllerBase
    {

        private ILogger _logger;
        private IPageContentService _service;


        public PageContentController(ILogger<PageContentController> logger, IPageContentService service)
        {
            _logger = logger;
            _service = service;

        }

        [HttpGet("/api/pagecontent")]
        public ActionResult<List<PageContent>> GetPages()
        {
            return _service.GetPages();
        }

        [HttpPost("/api/pagecontent")]
        public ActionResult<PageContent> AddPage([FromBody]PageContent page)
        {
            _service.AddPage(page);
            return page;
        }

        [HttpPut("/api/pagecontent/{id}")]
        public ActionResult<PageContent> UpdatePage(string id, [FromBody]PageContent page)
        {
            _service.UpdatePage(id, page);
            return page;
        }

        [HttpDelete("/api/pagecontent/{id}")]
        public ActionResult<string> DeletePage(string id)
        {
            _service.DeletePage(id);
            return id;
        }
    }
}
