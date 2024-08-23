using Microsoft.AspNetCore.Mvc;
using Room_Services.Models;
using System.Diagnostics;

namespace Room_Services.Controllers
{
    public class HomeController : Controller
    {
        private readonly RM_Context _context;

        public HomeController(RM_Context context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            var order = new Order(45);
            _context.Orders.Add(order);
            _context.SaveChanges();
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
    }
}
