using AutoMapper;
using Business.Dtos.Requests.GroupRequests;
using Business.Dtos.Responses.GroupResponses;
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


            CreateMap<Group, GetListGroupResponse>().ReverseMap();
            CreateMap<Paginate<Group>, Paginate<GetListGroupResponse>>();

            CreateMap<UpdateGroupRequest, Group>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<Group, UpdatedGroupResponse>();
        }
    }
}
