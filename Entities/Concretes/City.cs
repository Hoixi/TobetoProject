using Core.Entities;

namespace Entities.Concretes
{
    public class City : Entity<int>
    {
        public string Name { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}
