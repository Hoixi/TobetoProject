using Core.Entities;

namespace Entities.Concretes
{
    public class Town:Entity<int>
    {
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
