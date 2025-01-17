using FrontoBackSqlConnection.Data;
using FrontoBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontoBackSqlConnection.Controllers
{
    public class PricingController : Controller
    {
        //Dependency injection
        private readonly MentorAppDbContext _context;
        //Dependency Lifetimes:
        //1. Transient: 
        //2. Scoped: 
        //3. Singleton: 

        public PricingController(MentorAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            PricingVM pricingVM=new PricingVM();

            pricingVM.Pricings= _context.Pricings
                .Include(p => p.PricingServices)
                .ThenInclude(ps => ps.Service)
                .ToList();

            pricingVM.Services= _context.Services.ToList();

            return View(pricingVM);
        }
    }
}
