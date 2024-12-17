using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.ApiService.Models;
using OnionArchitecture.Contracts;

namespace OnionArchitecture.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController(ILoggerManager logger) : ControllerBase
    {
        [HttpGet("get")]
        public WeatherForecast Get()
        {
            logger.LogInfo("Getting weather forecast");
            return new WeatherForecast
            {
                Date = new DateOnly(2021, 1, 1),
                TemperatureC = 25,
                Summary = "Sunny"
            };
        }
    }
}
