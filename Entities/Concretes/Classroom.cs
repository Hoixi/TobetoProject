using Core.Entities;

namespace Entities.Concretes;

public class Classroom : Entity<int>
{   
    public string Name { get; set; }
    public string Group { get; set; }
}
