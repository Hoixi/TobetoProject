using Core.Entities;

namespace Entities.Concretes
{
    public class UserLanguage:Entity<int>
    {
        public int UserId { get; set; }
        public int LanguageId { get; set; }
        public int LanguageLevelId { get; set; }
        public User User { get; set; }

    }
}
