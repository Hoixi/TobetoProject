using Core.Entities;

namespace Entities.Concretes;

public class Course : Entity<int>
{
    public string İmageId { get; set; }
    public string Name { get; set; }
}
