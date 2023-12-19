using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CourseSubTypeRequests
{
    public class UpdateCourseSubTypeRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
