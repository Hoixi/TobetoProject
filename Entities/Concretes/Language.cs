using Core.Entities;

namespace Entities.Concretes;

public class Language : Entity<int>
{
    public string Name { get; set; }
    public List<UserLanguage> UserLanguages { get; set; }
}
