using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Equal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]

        public IActionResult Index()
        {
            return View("Index")
        }
    }
}