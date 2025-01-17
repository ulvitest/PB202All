using FrontoBackSqlConnection.Models;

namespace FrontoBackSqlConnection.ViewModels
{
    public class PricingVM
    {
        public List<Pricing> Pricings { get; set; }
        public List<Service> Services { get; set; }
    }
}
