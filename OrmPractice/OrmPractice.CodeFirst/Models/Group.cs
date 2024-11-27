using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrmPractice.CodeFirst.Models
{
    internal class Group
    {
       
        public int Id { get; set; }
        public string No { get; set; }
        public int Limit { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
