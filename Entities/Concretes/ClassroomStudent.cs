using Core.Entities;

namespace Entities.Concretes
{
    public class ClassroomStudent:Entity<int>
    {
        public int ClassroomGroupId { get; set; }
        public int StudentId { get; set; }
    }
}
