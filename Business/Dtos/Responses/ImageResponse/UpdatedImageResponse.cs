using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ImageResponse
{
    public class UpdatedImageResponse
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
