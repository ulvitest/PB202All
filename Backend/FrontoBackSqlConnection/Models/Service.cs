using FrontoBackSqlConnection.Attributies;
using System.ComponentModel.DataAnnotations;

namespace FrontoBackSqlConnection.Models
{
    public class Service
    {
        public int Id { get; set; }
        //[Required,StringLength(20)]
        //[MaxLength(20)]
        public string Name { get; set; }
        public List<PricingServices> PricingServices { get; set; }
    }
}
