using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfEducationDal : EfRepositoryBase<Education, int, TobetoContext>, IEducationDal
{
    public EfEducationDal(TobetoContext context) : base(context)
    {


    }
}
