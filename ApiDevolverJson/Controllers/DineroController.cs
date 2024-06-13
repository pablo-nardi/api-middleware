using ApiDevolverJson.Utils;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ApiDevolverJson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DineroController : Controller
    {
        [EnableCors("CorsBasico")]
        [HttpGet]
        public string Get()
        {
            //return new string[] { "value1", "value2" };
            ArmadoDeJson armadoDeJson = new ArmadoDeJson();
            return armadoDeJson.DevolverJson();
        }
    }
}
