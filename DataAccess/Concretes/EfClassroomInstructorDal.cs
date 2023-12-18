using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfClassroomInstructorDal : EfRepositoryBase<ClassroomInstructor, int, TobetoContext>, IClassroomInstructorDal
{
    public EfClassroomInstructorDal(TobetoContext context) : base(context)
    {


    }
}
