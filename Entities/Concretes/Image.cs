using Core.Entities;

namespace Entities.Concretes
{
    public class Image:Entity<int>
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public User User { get; set; }
        public List<Badge> Badges { get; set; }
    }
}
