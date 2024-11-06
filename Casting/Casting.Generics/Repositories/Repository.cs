using Casting.Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Generics.Repositories
{
    internal interface IRepository<T> where T : BaseEntity
    {
        void Add(T data);
        void Update();
        void Delete();
        void GetAll();
    }
}
