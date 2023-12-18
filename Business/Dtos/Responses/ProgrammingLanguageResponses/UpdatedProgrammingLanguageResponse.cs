using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.ProgrammingLanguageResponses
{
    public class UpdatedProgrammingLanguageResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
