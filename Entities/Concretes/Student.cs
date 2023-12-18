using Core.Entities;

namespace Entities.Concretes
{
    public class Student:Entity<int>
    {
        public int UserId { get; set; }
        public int StudentNumber { get; set; }
    }
}
