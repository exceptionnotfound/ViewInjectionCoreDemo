using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewInjectionCoreDemo.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        // GET api/values
        [HttpGet]
        [Route("all")]
        [Route("~/")]
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
