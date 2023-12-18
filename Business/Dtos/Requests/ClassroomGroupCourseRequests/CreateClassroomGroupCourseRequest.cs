using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ClassroomGroupCourseRequests
{
    public class CreateClassroomGroupCourseRequest
    {
        public int ClassroomGroupId { get; set; }
        public int CourseId { get; set; }
    }
}
