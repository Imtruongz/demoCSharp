using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Net.WebSockets;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Test()
        {
            var subject = new List<dynamic>();
            subject.Add(new
            {
                MaMon = "123",
                TenMon = "Ngôn ngữ lập trình C"
            });
            subject.Add(new
            {
                MaMon = "234",
                TenMon = "Lập trình .NET"
            });
            subject.Add(new
            {
                MaMon = "345",
                TenMon = "Lập trình web nâng cao"
            });
            ViewBag.subjectslst = subject;
            ViewBag.subjects = new SelectList(subject, "MaMon", "TenMon");

            return View();
        }
    }
}