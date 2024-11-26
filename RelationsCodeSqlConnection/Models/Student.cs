

using System.ComponentModel.DataAnnotations.Schema;

namespace RelationsCodeSqlConnection.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //public int GroupId { get; set; }
        //public Group Group { get; set; }
        public override string ToString()
        {
            return Id+" "+Name+ " "+Age;
        }
    }
}
