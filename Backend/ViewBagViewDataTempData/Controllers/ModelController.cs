using Microsoft.AspNetCore.Mvc;
using ViewBagViewDataTempData.Models;

namespace ViewBagViewDataTempData.Controllers
{
    public class ModelController : Controller
    {
        private List<CarModel> carModels = new()
        {
            new() { Id = 1, Name = "3 Series", BrandId = 1 },
            new() { Id = 2, Name = "5 Series", BrandId = 1 },
            new() { Id = 3, Name = "E Class", BrandId = 2 },
            new() { Id = 4, Name = "S Class", BrandId = 2 },
            new() { Id = 5, Name = "A6", BrandId = 3 },
            new() { Id = 6, Name = "A8", BrandId = 3 },
            new() { Id = 7, Name = "Corolla", BrandId = 4 },
            new() { Id = 8, Name = "Camry", BrandId = 4 },
            new() { Id = 9, Name = "Clio", BrandId = 5 },
            new() { Id = 10, Name = "Megane", BrandId = 5 }
        };
        public IActionResult Index(int?brandId)
        {
            if (brandId is null)
               return View(carModels);
            if (carModels.Any(x => x.BrandId == brandId))
                return View(carModels.Where(x => x.BrandId == brandId).ToList());
            return NotFound();
        }
    }
}
