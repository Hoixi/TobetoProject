using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.AnnouncementRequests
{
    public class CreateAnnoucementRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
