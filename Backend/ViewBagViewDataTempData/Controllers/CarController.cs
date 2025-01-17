using Microsoft.AspNetCore.Mvc;
using ViewBagViewDataTempData.Models;

namespace ViewBagViewDataTempData.Controllers
{
    public class CarController : Controller
    {
        private List<Car> cars = new()
        {
            new() { Id = 1, Name = "3 Series", ModelId = 1 },
            new() { Id = 2, Name = "5 Series", ModelId = 1 },
            new() { Id = 3, Name = "E Class", ModelId = 6 },
            new() { Id = 4, Name = "S Class", ModelId = 2 },
            new() { Id = 5, Name = "A6", ModelId = 3 },
            new() { Id = 6, Name = "A8", ModelId = 7 },
            new() { Id = 7, Name = "Corolla", ModelId = 4 },
            new() { Id = 8, Name = "Camry", ModelId = 8 },
            new() { Id = 9, Name = "Clio", ModelId = 9 },
            new() { Id = 10, Name = "Megane", ModelId = 5 },
            new () { Id = 11, Name = "A4", ModelId = 10 },
        };
        public IActionResult Index(int?modelId)
        {
            if (modelId is null)
                return View(cars);
            if (cars.Any(x => x.ModelId == modelId))
                return View(cars.Where(x => x.ModelId == modelId).ToList());
            return NotFound();
        }
        public IActionResult Detail(int? id)
        {
            if (id is null)
                return BadRequest();
            if (cars.Any(x => x.Id == id))
                return View(cars.FirstOrDefault(x => x.Id == id));
            return NotFound();
        }
    }
}
