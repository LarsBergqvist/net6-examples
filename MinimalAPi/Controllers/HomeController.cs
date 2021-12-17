using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinimalAPi1.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IMyService _service;
        private readonly ILogger<HomeController> _logger;
        public HomeController(IMyService service, ILogger<HomeController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<Greeting> GetGreeting()
        {
            _logger.LogInformation($"In {nameof(GetGreeting)}");
            return Ok(_service.GetGreeting());
        }
    }
}

