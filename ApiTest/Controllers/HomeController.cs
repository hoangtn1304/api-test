using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTest.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger<BaseController> logger) : base(logger)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET");
        }

        [HttpPost("/post/{name}")]
        public IActionResult Post(string name)
        {
            return Ok("POST " + name);
        }

        [HttpPut("/put/{id}")]
        public IActionResult Put(int id)
        {
            return Ok("PUT " + id);
        }

        [HttpDelete("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("DELETE " + id);
        }
    }
}