using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger) {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get() {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();


            List<string> strings = new List<string>();

            strings.Add("test1");
            strings.Add("test2");

            return strings;
        }

        [HttpGet("{id}", Name = "AllStrings")]
        public IEnumerable<string> AllStrings(int id) {

            List<string> strings = new List<string>();

            strings.Add("test4");
            strings.Add("test3");

            return strings;

        }
    }
}
