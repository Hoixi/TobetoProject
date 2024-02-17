using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.TownResponses
{
    public class GetListByCityIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
    }
}
