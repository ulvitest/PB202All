using Microsoft.AspNetCore.Mvc;
using ViewBagViewDataTempData.Models;
using ViewBagViewDataTempData.ViewModels;

namespace ViewBagViewDataTempData.Controllers
{
    public class TestController:Controller
    {
        public IActionResult Index()
        {
            Brand brand = new() { Id = 1, Name = "Brand 1" };
            CarModel carModel = new() { Id = 1, Name = "Car Model 1" };
            Car car= new() { Id = 1, Name = "Car 1" };

            TestVM testVM=new() { Car = car, Brand = brand, CarModel = carModel };
            return View(testVM);
        }
    }
}
