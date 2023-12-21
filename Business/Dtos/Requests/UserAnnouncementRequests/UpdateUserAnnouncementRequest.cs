using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserAnnouncementRequests
{
    public class UpdateUserAnnouncementRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AnnouncementId { get; set; }
    }
}
