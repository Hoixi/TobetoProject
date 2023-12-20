using AutoMapper;
using Business.Dtos.Requests.CertificateRequests;
using Business.Dtos.Responses.CertificateResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CertificateProfile : Profile
    {
        public CertificateProfile()
        {
            CreateMap<CreateCertificateRequest, Certificate>();
            CreateMap<Certificate, CreatedCertificateResponse>();


            CreateMap<Certificate, GetListCertificateResponse>().ReverseMap();
            CreateMap<Paginate<Certificate>, Paginate<GetListCertificateResponse>>();

            CreateMap<UpdateCertificateRequest, Certificate>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Certificate, UpdatedCertificateResponse>();
        }
    }
}
