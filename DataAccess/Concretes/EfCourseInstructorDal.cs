using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfCourseInstructorDal : EfRepositoryBase<CourseInstructor, int, TobetoContext>, ICourseInstructorDal
{
    public EfCourseInstructorDal(TobetoContext context) : base(context)
    {


    }
}
