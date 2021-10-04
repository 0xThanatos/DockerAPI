using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DockerAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class HealthzController : ControllerBase
  {
    [HttpGet]
    public ActionResult<string> Get()
    {
      return "OK";
    }
  }
}
