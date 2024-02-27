using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseResponses
{
    public class GetListCourseResponse
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public string Description { get; set; }
        public int SubTypeId { get; set; }
        public string SubTypeName { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

    }
}
