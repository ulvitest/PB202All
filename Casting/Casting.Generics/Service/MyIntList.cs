using Casting.Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Generics.Service
{
    internal class MyList<T> where T : struct, IComparable
        //where T : U
        //where T : Test
        //where T : IComparable
        //where T : new()
        //where T : class
        //where T : struct
    {
        private T[] _array;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T value)
        {
            Array.Resize(ref _array,_array.Length+1);
            _array[_array.Length-1] = value;
        }
        public void ShowAll()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }
    }
   
}
