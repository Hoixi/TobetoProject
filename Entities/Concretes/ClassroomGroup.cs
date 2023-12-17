using Core.Entities;

namespace Entities.Concretes;

public class ClassroomGroup : Entity<int>
{
    public int Id { get; set; }
    public int ClassroomId { get; set; }
    public int GroupId { get; set; }
}
