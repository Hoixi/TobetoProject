using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserSkillRequests
{
    public class UpdateUserSkillRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SkillId { get; set; }
    }
}
