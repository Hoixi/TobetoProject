using Core.Entities;

namespace Entities.Concretes
{
    public class Skill:Entity<int>
    {
        public string Name { get; set; }
        public List<UserSkill> UserSkills { get; set; }
    }
}
