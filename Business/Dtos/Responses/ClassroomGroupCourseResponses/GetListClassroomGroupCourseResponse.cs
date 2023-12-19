using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClassroomGroupCourseResponses
{
    public class GetListClassroomGroupCourseResponse
    {
        public int Id { get; set; }
        public int ClassroomGroupId { get; set; }
        public int CourseId { get; set; }
    }
}
