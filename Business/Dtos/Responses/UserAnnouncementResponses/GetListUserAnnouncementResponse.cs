using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserAnnouncementResponses
{
    public class GetListUserAnnouncementResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AnnouncementId { get; set; }
    }
}
