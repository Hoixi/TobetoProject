using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClassroomStudentResponses
{
    public class UpdatedClassroomStudentResponse
    {
        public int Id { get; set; }
        public int ClassroomGroupId { get; set; }
        public int StudentId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
