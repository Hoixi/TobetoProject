using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserServeyResponses
{
    public class GetListUserSurveyResponse
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SurveyId { get; set; }
    }
}
