using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Recap.Three.Models;
using Recap.Three.Services;

namespace Recap.Three.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BugController : ControllerBase
    {
        private readonly ILogger<BugController> _logger;
        private readonly IBugTrackerService _service;

        public BugController(ILogger<BugController> logger, IBugTrackerService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Bug> Get()
        {
            return _service.GetBugs();
        }

        [HttpGet("[action]")]
        public int Count()
        {
            return _service.Count;
        }

        [HttpGet("{id}")]
        public IActionResult GetBug(int id)
        {
            var bug = _service.GetBug(id);
            if (bug == null)
                return NotFound();
            
            return Ok(bug);
        }

        [HttpPost]
        public int CreateBug(Bug bug)
        {
            return _service.AddBug(bug);
        }

        [HttpPut]
        public Bug UpdateBug(Bug bug)
        {
            return _service.UpdateBug(bug);
        }

        [HttpDelete("{id}")]
        public bool DeleteBug(int id)
        {
            return _service.RemoveBug(id);
        }
    }
}
