using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.GroupRequests
{
    public class UpdateGroupRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
