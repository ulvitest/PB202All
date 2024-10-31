using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Interfaces
{
    internal interface IRepository //CRUD
    {
        void Add();
        void Update();
        void Delete();
        void GetAll();
    }
}
