using Microsoft.AspNetCore.Mvc;
using ViewBagViewDataTempData.Models;

namespace ViewBagViewDataTempData.Controllers
{
    public class HomeController:Controller
    {
        private List<Brand> brands=new()
        { 
            new Brand{Id=1,Name="BMW"},
            new Brand{Id=2,Name="Mercedes"},
            new Brand{Id=3,Name="Audi"},
            new Brand{Id=4,Name="Toyota"},
            new Brand{Id=5,Name="Renault"},

        };
        public IActionResult Index()
        {
            //ViewData["Brands"]=brands;
            ViewBag.Brands=brands;
            //TempData["Brands"]=brands;
            //ViewBag.Group = "PB202";
            //ViewData["Size"] = 20;
            //TempData["Subject"] = "Programing";

            return View();

            //return RedirectToAction(nameof(About));
        }
        //public IActionResult About()
        //{
        //    return View();
        //}
    }
}
