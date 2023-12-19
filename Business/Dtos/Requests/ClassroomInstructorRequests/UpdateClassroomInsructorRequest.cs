using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ClassroomInstructorRequests
{
    public class UpdateClassroomInstructorRequest
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int ClassroomId { get; set; }
    }
}
