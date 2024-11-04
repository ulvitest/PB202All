using StaticExtension.Lesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension.Lesson.Extensions
{
    internal static class StudentExtension
    {
        public static double GetPointAwg(this Student student)
        {
            double sum = 0;
            foreach (var point in student.Points)
            {
                sum += point;
            }
            return sum / student.Points.Length;
        }
    }
}
