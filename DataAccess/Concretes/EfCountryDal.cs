using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfCountryDal : EfRepositoryBase<Country, int, TobetoContext>, ICountryDal
{
    public EfCountryDal(TobetoContext context) : base(context)
    {


    }
}
