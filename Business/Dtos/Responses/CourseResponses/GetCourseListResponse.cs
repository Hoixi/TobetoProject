using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseResponses
{
    public class GetCourseListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

    }
}
