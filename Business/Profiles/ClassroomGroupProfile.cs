using AutoMapper;
using Business.Dtos.Requests.ClassroomGroupRequests;
using Business.Dtos.Responses.ClassroomGroupResponses;
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
    public class ClassroomGroupProfile : Profile
    {
        public ClassroomGroupProfile()

        {
            CreateMap<CreateClassroomGroupRequest, ClassroomGroup>();
            CreateMap<ClassroomGroup, CreatedClassroomGroupResponse>();

            CreateMap<ClassroomStudent, GetListClassroomStudentResponse>();
            CreateMap<ClassroomGroup, GetListClassroomGroupResponse>()

                .ForMember(dest => dest.ClassroomName, opt => opt.MapFrom(src => src.Classroom.Name))                
                .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.Group.Name))
                .ForMember(dest => dest.Students, opt => opt.MapFrom(src => src.ClassroomStudents))
                .ReverseMap();
            CreateMap<Paginate<ClassroomGroup>, Paginate<GetListClassroomGroupResponse>>();

            CreateMap<UpdateClassroomGroupRequest, ClassroomGroup>().ForMember(dest => dest.CreatedDate, opt => opt.Ignore());
            CreateMap<ClassroomGroup, UpdatedClassroomGroupResponse>();
        }
    }
}

/*
ClassroomInstructorProfile.cs,ClassroomProfile.cs,ClassroomStudentProfile.cs,CompanyProfile.cs,CountryProfile.cs,CourseCategoryProfile.cs,CourseCompanyProfile.cs,CourseProfile.cs,CourseSubTypeProfile.cs,EducationDegreeProfile.cs,EducationProfile.cs,ExperienceProfile.cs,GroupProfile.cs,lmageProfile.cs,InstructorProfile.cs,LanguageLevelProfile.cs,LanguageProfile.cs,ProgrammingLanguageProfile.cs,SchoolNameProfile.cs,SkillProfile.cs,SocialMediaProfile.cs,StudentProfile.cs
 */