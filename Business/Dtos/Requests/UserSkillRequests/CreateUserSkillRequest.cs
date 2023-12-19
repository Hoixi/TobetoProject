using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserSkillRequests
{
    public class CreateUserSkillRequest
    {
        public int UserId { get; set; }
        public int SkillId { get; set; }
    }
}
