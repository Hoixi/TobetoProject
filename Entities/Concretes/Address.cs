using Core.Entities;

namespace Entities.Concretes
{
    public class Address : Entity<int>
    {
        public int UserId { get; set; }
        public int TownId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Description { get; set; }
    }
}
