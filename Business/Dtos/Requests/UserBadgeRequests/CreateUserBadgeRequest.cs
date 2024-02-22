using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserBadgeRequests
{
    public class CreateUserBadgeRequest
    {
        public int UserId { get; set; }
        public int BadgeId { get; set; }
    }
}
