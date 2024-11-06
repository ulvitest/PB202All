using IndexerException.Lesson.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Lesson.Models
{
    internal class Order
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus Status { get; set; }
    }
}
