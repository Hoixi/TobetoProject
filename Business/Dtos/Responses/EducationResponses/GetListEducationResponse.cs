using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.EducationResponses
{
    public class GetListEducationResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string EducationDegreeName { get; set; }
        public string School { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
