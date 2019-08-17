using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace microservice_template.Controllers
{
    [Route("system/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        // GET system/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok();
        }
    }
}
