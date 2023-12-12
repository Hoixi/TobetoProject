using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.InstructorRequests
{
    public class CreateInstructorRequest
    {
        public int UserId { get; set; }
        public int CourseId { get; set; }
    }
}
