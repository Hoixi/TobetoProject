using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserLanguageRequests
{
    public class CreateUserLanguageRequest
    {
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public int LanguageLevelId { get; set; }
    }
}
