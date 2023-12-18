using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfClassroomGroupDal : EfRepositoryBase<ClassroomGroup, int, TobetoContext>, IClassroomGroupDal
{
    public EfClassroomGroupDal(TobetoContext context) : base(context)
    {


    }
}
