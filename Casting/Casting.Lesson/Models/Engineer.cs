using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Lesson.Models
{
    internal abstract class Engineer:Person
    {
        public string[] Knowledges { get; set; }
    }
}
