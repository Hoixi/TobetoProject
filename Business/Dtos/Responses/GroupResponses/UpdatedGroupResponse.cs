using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.GroupResponses
{
    public class UpdatedGroupResponse
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
