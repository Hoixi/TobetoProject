using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.ExperienceRequests
{
    public class CreateExperienceRequest
    {
        public int UserId { get; set; }
        public int CityId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Sector { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
