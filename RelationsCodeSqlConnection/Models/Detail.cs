

using System.ComponentModel.DataAnnotations.Schema;

namespace RelationsCodeSqlConnection.Models
{
    internal class Detail
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        //[ForeignKey(nameof(Student))]
        public int StudenId { get; set; }
        public Student Student { get; set; }

    }
}
