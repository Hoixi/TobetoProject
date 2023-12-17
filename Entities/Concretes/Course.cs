using Core.Entities;

namespace Entities.Concretes;

public class Course : Entity<int>
{
    public string ImageId { get; set; }
    public string Name { get; set; }
}
