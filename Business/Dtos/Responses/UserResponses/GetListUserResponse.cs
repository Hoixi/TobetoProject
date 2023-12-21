using Business.Dtos.Responses.CertificateResponses;
using Business.Dtos.Responses.UserLanguageResponses;
using Business.Dtos.Responses.UserSocialMediaResponses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.UserResponses
{
    public class GetListUserResponse
    {
        public int Id { get; set; }
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ImageId { get; set; }
        public DateTime BirthDate { get; set; }
        public List<GetListUserSocialMediaResponse> UserSocialMedias { get; set; }
        public List<GetListUserLanguageResponse> UserLanguages{ get; set; }
        public List<GetListCertificateResponse> Certificates { get; set; }
    }
}
