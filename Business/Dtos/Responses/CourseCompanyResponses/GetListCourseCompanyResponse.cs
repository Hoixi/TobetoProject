using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseCompanyResponses
{
    public class GetListCourseCompanyResponse
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CompanyName { get; set; }
    }
}
