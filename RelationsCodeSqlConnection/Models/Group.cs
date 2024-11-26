using System.ComponentModel.DataAnnotations;

namespace RelationsCodeSqlConnection.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public List<Student> Students { get; set; }
    }
}
