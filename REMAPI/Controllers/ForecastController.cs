using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AngularDncApp.Controllers
{
    [ApiController]
    [Route("remapi/[controller]")]
    public class ForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ForecastController> _logger;

        public ForecastController(ILogger<ForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Dictionary<string,string> Get()
        {
            var rng = new Random();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var res = "Result from rem api: " + rng.Next(0, 100).ToString(); 
            dict.Add("msg",res);
            return dict;
        }
    }
}
