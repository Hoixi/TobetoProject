using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.CityResponses
{
    public class UpdatedCityResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
