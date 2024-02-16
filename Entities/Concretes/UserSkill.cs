using Core.Entities;

namespace Entities.Concretes
{
    public class UserSkill:Entity<int>
    {
        public int UserId { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
