using Core.Entities;

namespace Entities.Concretes;

public class Classroom : Entity<int>
{    
    public string Name { get; set; }
    public List<ClassroomGroup> ClassroomGroups { get; set; }
}
