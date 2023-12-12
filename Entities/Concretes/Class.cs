using Core.Entities;

namespace Entities.Concretes;

public class Class : Entity<int>
{   
    public string Name { get; set; }
    public string Classroom { get; set; }
}
