using Core.Entities;

namespace Entities.Concretes;

public class Certificate : Entity<int>
{   
    public int UserId { get; set; }
    public string Path { get; set; }
    public string FileName { get; set; }
    public User User { get; set; }
}
