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
        public string ClassroomGroupName { get; set; }
        public string CourseName { get; set; }
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
    }
}
