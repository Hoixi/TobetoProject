using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfClassroomDal : EfRepositoryBase<Classroom, int, TobetoContext>, IClassroomDal
{
    public EfClassroomDal(TobetoContext context) : base(context)
    {


    }
}

