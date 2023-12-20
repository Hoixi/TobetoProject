using AutoMapper;
using Business.Dtos.Requests.SurveyRequests;
using Business.Dtos.Responses.SurveyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class SurveyProfile : Profile
    {
        public SurveyProfile()

        {
            CreateMap<CreateSurveyRequest, Survey>();
            CreateMap<Survey, CreatedSurveyResponse>();


            CreateMap<Survey, GetListSurveyResponse>().ReverseMap();
            CreateMap<Paginate<Survey>, Paginate<GetListSurveyResponse>>();

            CreateMap<UpdateSurveyRequest, Survey>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Survey, UpdatedSurveyResponse>();
        }
    }
}
