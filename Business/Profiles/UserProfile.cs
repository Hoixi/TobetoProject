using AutoMapper;
using Business.Dtos.Requests.UserRequests;
using Business.Dtos.Responses.UserResponses;
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
        }
    }
}
