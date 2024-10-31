using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Models
{
    internal class ProgrammerEngineer : Engineer
    {
        public string Language { get; set; }
        public override string Info()
        {
            return "programmer info";
        }
        public override string Detail()
        {
            return "programmer detail";
        }

        public override void GetEngineerExperience()
        {
            throw new NotImplementedException();
        }
    }
}
