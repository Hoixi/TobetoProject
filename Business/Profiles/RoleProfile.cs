using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class RoleProfile:Profile
    {
        public RoleProfile() 
        
        {
            CreateMap<CreateRoleRequest, Role>();        
            CreateMap<Role, CreatedRoleResponse>();


            CreateMap<Role, GetListRoleResponse>().ReverseMap();
            CreateMap<Paginate<Role>, Paginate<GetListRoleResponse>>();


        }


    }
}
