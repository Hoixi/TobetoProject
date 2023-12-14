using AutoMapper;
using Business.Dtos.Requests.CourseRequests;
using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Responses.ClasroomResponses;
using Business.Dtos.Responses.CourseResponses;
using Business.Dtos.Responses.GroupResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<CreateGroupRequest, Group>();
            CreateMap<Group, CreatedGroupResponse>();

            CreateMap<UpdateGroupRequest, Group>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Group, UpdatedGroupResponse>();

            CreateMap<Group, GetGroupListResponse>().ReverseMap();
            CreateMap<Paginate<Group>, Paginate<GetGroupListResponse>>().ReverseMap();
        }

    }
}
