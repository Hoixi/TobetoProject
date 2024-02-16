using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserSkillResponses
{
    public class GetListUserSkillResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SkillId { get; set; }
        public string SkillName{ get; set; }
    }
}
