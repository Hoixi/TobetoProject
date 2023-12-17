using Core.Entities;

namespace Entities.Concretes;

public class Classroom : Entity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
