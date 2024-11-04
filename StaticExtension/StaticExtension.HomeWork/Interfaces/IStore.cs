using StaticExtension.HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension.HomeWork.Interfaces
{
    internal interface IStore
    {
        public Product[] Products { get; }
        public int ProductLimit { get; set; }
        public double TotalInCome { get;}
        void AddProduct(Product product);
        void SellProduct(string productName);
    }
}
