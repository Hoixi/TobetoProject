using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserBadgeResponses
{
    public class GetListUserBadgeResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BadgeId { get; set; }        
        public string BadgeName { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
    }
}
