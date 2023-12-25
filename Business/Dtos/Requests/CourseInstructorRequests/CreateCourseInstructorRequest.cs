using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ClassroomInstructorRequests
{
    public class CreateCourseInstructorRequest
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
    }
}
