using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfCityDal : EfRepositoryBase<City, int, TobetoContext>, ICityDal
{
    public EfCityDal(TobetoContext context) : base(context)
    {


    }
}
