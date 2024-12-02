using Academy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Service.Dtos.GroupDtos
{
    public class GroupReturnDto
    {
        public string No { get; set; }
        public int Limit { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Student> Students { get; set; }

    }
}
