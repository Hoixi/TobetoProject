using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.BadgeRequests
{
    public class CreateBadgeRequest
    {
        public int ImageId { get; set; }
        public string Name { get; set; }
    }
}
