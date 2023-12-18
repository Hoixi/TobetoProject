using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CertificateResponses
{
    public class GetListCerficateResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
    }
}
