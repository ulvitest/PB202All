

using System.ComponentModel.DataAnnotations;

namespace Academy.Core.Entities
{
    public class Group:BaseEntity
    {
        //[Required]
        //[MaxLength(3)]
        //[StringLength(100)]
        public string No { get; set; }
        public int Limit { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Student> Students { get; set; }

        public override string ToString()
        {
            return Id+" "+No+" "+Limit;
        }
    }
}
