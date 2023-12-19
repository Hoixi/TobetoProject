using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserAnnouncementRequests
{
    public class CreateUserAnnouncementRequest
    {
        public int UserId { get; set; }
        public string AnnouncementId { get; set; }
    }
}
