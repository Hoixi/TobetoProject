using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserServeyRequests
{
    public class CreateUserSurveyRequest
    {
        public int StudentId { get; set; }
        public int SurveyId { get; set; }
    }
}
