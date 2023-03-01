using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission09_astowe.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_astowe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private BookstoreContext context { get; set; }

        public HomeController (BookstoreContext cntx)
        {
            context = cntx;
        }

        public IActionResult Index()
        {
            var data = context.Books.ToList();

            return View(data);
        }

    }
}
