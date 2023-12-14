using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ClassroomRequests
{
    public class UpdateClassroomRequest
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        //public string Group { get; set; }

    }
}
