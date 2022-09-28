using Microsoft.AspNetCore.Mvc;

namespace WebAppTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRandomInt")]
        public int GetRandomInt()
        {
            return new Random().Next(0, 1000);
        }
    }
}
