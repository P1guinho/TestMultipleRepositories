using Microsoft.AspNetCore.Mvc;

namespace TESTE.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>();
        }
    }
}