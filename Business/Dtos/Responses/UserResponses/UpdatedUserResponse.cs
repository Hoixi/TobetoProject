using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserResponses
{
    public class UpdatedUserResponse
    {
        public int Id { get; set; }
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ImageId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
