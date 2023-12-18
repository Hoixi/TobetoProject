using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfClassroomStudentDal : EfRepositoryBase<ClassroomStudent, int, TobetoContext>, IClassroomStudentDal
{
    public EfClassroomStudentDal(TobetoContext context) : base(context)
    {


    }
}
