using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Homework.Models
{
    internal abstract class Product
    {
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        protected double TotalInCome { get; set; }
        public Product()
        {
            _id++;
            Id= _id;
            
        }
        public abstract void Sell();
        public abstract void ShowInfo();


    }
}
