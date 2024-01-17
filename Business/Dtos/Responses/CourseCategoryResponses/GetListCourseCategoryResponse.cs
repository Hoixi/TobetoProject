using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CourseCategoryResponses
{
    public class GetListCourseCategoryResponse
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CategoryName { get; set; }
    }
}
