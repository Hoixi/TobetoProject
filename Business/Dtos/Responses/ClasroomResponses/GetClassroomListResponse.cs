using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClasroomResponses
{
    public class GetClassroomListResponse
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        //public string Group { get; set; }
    }
}
