using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [AllowAnonymous]
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
