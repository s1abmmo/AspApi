using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspApi;
using System.Text.Json;

namespace AspApi.Controllers.User
{
    [ApiController]
    [Route("signup")]
    public class Signup : Controller
    {
        private readonly ILogger<Signup> _logger;

        public Signup(ILogger<Signup> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> SignupAction([FromBody] AspApi.User user)
        {
            ContentResult cr = new ContentResult();
            cr.Content =  JsonSerializer.Serialize(user);
            return cr;
        }
    }
}
