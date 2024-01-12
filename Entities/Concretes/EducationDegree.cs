using Core.Entities;

namespace Entities.Concretes
{
    public class EducationDegree:Entity<int>
    {
        public string Name { get; set; }
        public List<Education> Educations { get; set; }
    }
}
