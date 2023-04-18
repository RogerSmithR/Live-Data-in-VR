using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LiveDataTransmiterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class heatvalue : ControllerBase
    {
        [HttpGet(Name = "GetHeatValue")]
        public string Get()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100).ToString();
        }
    }
}
