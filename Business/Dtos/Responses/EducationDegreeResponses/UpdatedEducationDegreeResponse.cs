using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.EducationDegreeResponses
{
    public class UpdatedEducationDegreeResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
