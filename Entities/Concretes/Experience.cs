using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Experience : Entity<int>
    {
        public int UserId { get; set; }
        public int CityId { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set;}
        public  string Sector { get; set; }
        public DateTime StartDate { get; set;}
        public DateTime ?EndDate { get; set;}
    }
}
