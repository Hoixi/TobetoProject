using AutoMapper;
using Business.Dtos.Requests.RoleRequests;
using Business.Dtos.Responses.RoleResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Business.Profiles
//{
//    public class RoleProfile:Profile
//    {
//        public RoleProfile() 
        
//        {
//            CreateMap<CreateRoleRequest, Role>();        
//            CreateMap<Role, CreatedRoleResponse>();


//            CreateMap<Role, GetListRoleResponse>().ReverseMap();
//            CreateMap<Paginate<Role>, Paginate<GetListRoleResponse>>();

//            CreateMap<UpdateRoleRequest,Role >().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
//            CreateMap<Role,UpdatedRoleResponse>();
//        }


//    }
//}
