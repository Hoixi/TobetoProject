using AutoMapper;
using Business.Dtos.Requests.UserCertificateRequests;
using Business.Dtos.Responses.UserCertificateResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserCertificateProfile : Profile
    {
        public UserCertificateProfile()

        {
            CreateMap<CreateUserCertificateRequest, UserCertificate>();
            CreateMap<UserCertificate, CreatedUserCertificateResponse>();


            CreateMap<UserCertificate, GetListUserCertificateResponse>().ReverseMap();
            CreateMap<Paginate<UserCertificate>, Paginate<GetListUserCertificateResponse>>();

            CreateMap<UpdateUserCertificateRequest, UserCertificate>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserCertificate, UpdatedUserCertificateResponse>();
        }
    }
}
