

using Academy.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Core.Entities
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public Grade  GradeName { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + Group.No;
        }
    }
}
