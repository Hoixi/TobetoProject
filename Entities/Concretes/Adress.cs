using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Adress : Entity<int>
    {
        public int UserId { get; set; }
        public int TownId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Description { get; set; }
    }
}
