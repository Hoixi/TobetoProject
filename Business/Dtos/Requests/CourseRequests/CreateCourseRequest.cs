using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.CourseRequests
{
    public class CreateCourseRequest
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int SubTypeId { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
