using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrmPractice.Lesson.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string No { get; set; }
        public override string ToString()
        {
            return Id + " " + No;
        }
    }
}
