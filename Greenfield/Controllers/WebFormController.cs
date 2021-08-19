using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Greenfield.Controllers
{
  [ApiController]
  [Route("WebForm.aspx")]
  public class WebFormController : ControllerBase
  {

    private readonly ILogger<WebFormController> _logger;

    public WebFormController(ILogger<WebFormController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
      return "GREENFIELD";
    }
  }
}
