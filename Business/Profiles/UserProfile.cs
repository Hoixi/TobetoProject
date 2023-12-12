using AutoMapper;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.UserResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();

            CreateMap<DeleteUserRequest, User>();
            CreateMap<User, DeleteUserResponse>();

            CreateMap<User, GetListUserResponse>().ReverseMap();
            CreateMap<Paginate<User>, Paginate<GetListUserResponse>>();

            CreateMap<UpdateUserRequest, User>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<User, UpdateUserResponse>();

        }
    }
}
