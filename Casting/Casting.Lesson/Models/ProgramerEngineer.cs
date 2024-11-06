using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting.Lesson.Models
{
    internal class ProgramerEngineer:Engineer
    {
        public string Language { get; set; }

        public override void Detail()
        {
            Console.WriteLine($"Id:{Id} Name:{Name} Lang:{Language}");
        }
    }
}
