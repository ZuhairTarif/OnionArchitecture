using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.ApiService.Models;

namespace OnionArchitecture.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpGet("get")]
        public WeatherForecast Get()
        {
            return new WeatherForecast
            {
                Date = new DateOnly(2021, 1, 1),
                TemperatureC = 25,
                Summary = "Sunny"
            };
        }
    }
}
