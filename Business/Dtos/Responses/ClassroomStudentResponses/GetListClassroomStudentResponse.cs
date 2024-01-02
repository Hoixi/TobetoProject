using Business.Dtos.Responses.ClassroomGroupCourseResponses;
using Business.Dtos.Responses.StudentResponses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClassroomStudentResponses
{
    public class GetListClassroomStudentResponse
    {
        public int Id { get; set; }
        public int ClassroomGroupId { get; set; }
        public int StudentId { get; set; }
        public string ClassroomGroupName { get; set; }
        public GetListStudentResponse Student { get; set; }
        //public List<ClassroomGroup> ClassroomGroups { get; set; }
        //public GetListClassroomGroupCourseResponse ClassroomGroupCourse { get; set; }
    }
}
