using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfClassroomGroupCourseDal : EfRepositoryBase<ClassroomGroupCourse, int, TobetoContext>, IClassroomGroupCourseDal
{
    public EfClassroomGroupCourseDal(TobetoContext context) : base(context)
    {


    }
}
