using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ImageRequests
{
    public class UpdateImageRequest
    {
        public int Id { get; set; }

        public string Path { get; set; }

    }
}
