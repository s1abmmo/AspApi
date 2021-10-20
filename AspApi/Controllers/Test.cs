using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspApi.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public String GetList(int id)
        {
            string test1=Request.Query["test1"];
            return id.ToString()+ test1;
        }

        [HttpPost("{id}")]
        public String PostList(int id)
        {
            return id.ToString();
        }

    }
}
