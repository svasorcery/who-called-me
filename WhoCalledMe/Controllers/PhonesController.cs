using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WhoCalledMe.Controllers
{
    [Route("api/[controller]")]
    public class PhonesController : Controller
    {
        [HttpGet]
        public IActionResult Get(string phoneNumber)
        {
            return Ok($"Get phone '{phoneNumber}' info...");
        }
    }
}
