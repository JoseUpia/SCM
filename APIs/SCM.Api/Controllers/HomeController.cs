using Microsoft.AspNetCore.Mvc;

namespace SCM.Api.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"SCM.API {_environment.EnvironmentName}");
        }
    }
}
