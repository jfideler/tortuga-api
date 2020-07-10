using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace tortuga_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private static readonly string[] Bands = new[]
        {
            "GBF", "Westside", "Boogie Wonderland", "MMC All Stars", "JB and the Routine", "Warm"
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Array Get()
        {
            string[] result = new string[1];
            result[0] = "Got me";
            
            return result;
        }
    }
}
