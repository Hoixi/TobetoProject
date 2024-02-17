using Core.Entities;

namespace Entities.Concretes
{
    public class Town:Entity<int>
    {
        public int CityId { get; set; }
        public string Name { get; set; }

        public City City { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
