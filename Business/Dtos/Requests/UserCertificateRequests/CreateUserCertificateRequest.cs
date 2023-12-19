using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserCertificateRequests
{
    public class CreateUserCertificateRequest
    {
        public int UserId { get; set; }
        public int CertificateId { get; set; }
    }
}
