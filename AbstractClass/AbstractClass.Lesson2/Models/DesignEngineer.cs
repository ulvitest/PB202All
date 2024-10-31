using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Lesson2.Models
{
    internal class DesignEngineer : Engineer
    {
        public string Lorem { get; set; }
        public override string Info()
        {
            return "design info";
        }

        public override string Detail()
        {
            return "design detail";
        }

        public override void GetEngineerExperience()
        {
            throw new NotImplementedException();
        }
    }
}
