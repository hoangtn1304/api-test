using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly ILogger<BaseController> Logger;

        public BaseController(ILogger<BaseController> logger)
        {
            Logger = logger;
        }

    }
}