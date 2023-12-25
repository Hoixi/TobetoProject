﻿using AutoMapper;
using Business.Dtos.Requests.ClassroomStudentRequests;
using Business.Dtos.Responses.ClassroomStudentResponses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ClassroomStudentProfile : Profile
    {
        public ClassroomStudentProfile()

        {
            CreateMap<CreateClassroomStudentRequest, ClassroomStudent>();
            CreateMap<ClassroomStudent, CreatedClassroomStudentResponse>();


            CreateMap<ClassroomStudent, GetListClassroomStudentResponse>()
                 .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
                .ReverseMap();
            CreateMap<Paginate<ClassroomStudent>, Paginate<GetListClassroomStudentResponse>>();

            CreateMap<UpdateClassroomStudentRequest, ClassroomStudent>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<ClassroomStudent, UpdatedClassroomStudentResponse>();
        }
    }
}
