using DevCard_Promote.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevCard_Promote.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }
        [HttpPost]

        public IActionResult Contact(Contact form)
        {
            return Json(Ok());
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
