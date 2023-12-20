using AutoMapper;
using Business.Dtos.Requests.UserSurveyRequests;
using Business.Dtos.Responses.UserSurveyResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserSurveyProfile : Profile
    {
        public UserSurveyProfile()

        {
            CreateMap<CreateUserSurveyRequest, UserSurvey>();
            CreateMap<UserSurvey, CreatedUserSurveyResponse>();


            CreateMap<UserSurvey, GetListUserSurveyResponse>().ReverseMap();
            CreateMap<Paginate<UserSurvey>, Paginate<GetListUserSurveyResponse>>();

            CreateMap<UpdateUserSurveyRequest, UserSurvey>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<UserSurvey, UpdatedUserSurveyResponse>();
        }
    }
}
