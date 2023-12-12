using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserResponses
{
    public class UpdateUserResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
    }
}
