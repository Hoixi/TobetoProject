using Core.Entities;

namespace Entities.Concretes
{
    public class User : Entity<int>
    {
        public  string  NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ImageId { get; set; }
        public  DateTime BirthDate { get; set; }
        public string Password { get; set; }

    }
}
