using Core.Entities;

namespace Entities.Concretes
{
    public class LanguageLevel:Entity<int>
    {
        public string Name { get; set; }
        public List<UserLanguage> UserLanguages { get; set; }
    }
}
