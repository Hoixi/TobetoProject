using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClassroomInstructorResponses
{
    public class UpdatedCourseInstructorResponse
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
    }
}
