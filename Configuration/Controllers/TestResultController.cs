using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Confuguration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestResultController : ControllerBase
    {
        public ClientSecret _clientSecret { get; }


        public TestResultController(IOptions<ClientSecret> clientSecret)
        {
            _clientSecret = clientSecret.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(JsonSerializer.Serialize(_clientSecret));
        }
    }
}
