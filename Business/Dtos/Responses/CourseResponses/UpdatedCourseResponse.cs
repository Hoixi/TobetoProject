using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseResponses
{
    public class UpdatedCourseResponse
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
