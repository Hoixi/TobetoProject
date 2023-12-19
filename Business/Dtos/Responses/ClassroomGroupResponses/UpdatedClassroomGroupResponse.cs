using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ClassroomGroupResponses
{
    public class UpdatedClassroomGroupResponse
    {
        public int Id { get; set; }
        public int ClassroomId { get; set; }
        public int GroupId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
