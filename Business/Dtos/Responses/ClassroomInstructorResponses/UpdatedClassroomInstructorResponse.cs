using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClassroomInstructorResponses
{
    public class UpdatedClassroomInstructorResponse
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int ClassroomId { get; set; }
    }
}
