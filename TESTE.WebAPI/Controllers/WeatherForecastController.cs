using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace TESTE.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var enum1 = EnumTeste.Test;

            return new List<string>();
        }
    }
}