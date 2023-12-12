using Core.Entities;

namespace Entities.Concretes
{
    public class Role:Entity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
