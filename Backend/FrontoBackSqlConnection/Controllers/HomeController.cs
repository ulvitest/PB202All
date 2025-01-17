
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontoBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }


      
    }
}
