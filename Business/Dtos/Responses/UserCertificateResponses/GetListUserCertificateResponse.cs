﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserCertificateResponses
{
    public class GetListUserCertificateResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CertificateId { get; set; }
    }
}
