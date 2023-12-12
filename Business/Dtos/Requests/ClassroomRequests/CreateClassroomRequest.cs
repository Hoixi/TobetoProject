using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ClassroomRequests
{
    public class CreateClassroomRequest
    {
        public string Name { get; set; }
        public string Group { get; set; }
    }
}
