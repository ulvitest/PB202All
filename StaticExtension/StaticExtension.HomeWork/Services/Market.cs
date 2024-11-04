using StaticExtension.HomeWork.Interfaces;
using StaticExtension.HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension.HomeWork.Services
{
    internal class Market : IStore
    {
        private Product[] _products;
        public Product[] Products=> _products;  
        public int ProductLimit { get; set ; }
        private double _totalInCome;
        public double TotalInCome => _totalInCome;

        public Market()
        {
            _products = new Product[0];
        }

        public void AddProduct(Product product)//iphone,Iphone
        {
           
            if (IsExistProduct(product.Name))
            {
                Console.WriteLine("already exist");
                return;
            }
             Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
            Console.WriteLine($"{product.Name} added");
        }
        private bool IsExistProduct(string name)
        {
            foreach (var pr in _products)
            {
                if (pr.Name.ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
        private Product FindProduct(string name)
        {
            foreach (var pr in _products)
            {
                if (pr.Name.ToUpper() == name.ToUpper())
                {
                    return pr;
                }
            }
            return null;
        }

        public void SellProduct(string productName)
        {
            var existproduct = FindProduct(productName);
            if (existproduct == null)
            {
                Console.WriteLine("not exist");
                return;
            }
            if (existproduct.Count==0)
            {
                Console.WriteLine("not exist");
                return;
            }
            existproduct.Count--;
            _totalInCome += existproduct.Price;



        }
    }
}
