using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfExperienceDal : EfRepositoryBase<Experience, int, TobetoContext>, IExperienceDal
{
    public EfExperienceDal(TobetoContext context) : base(context)
    {


    }
}
