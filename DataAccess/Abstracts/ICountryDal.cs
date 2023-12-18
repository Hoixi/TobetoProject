using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts;

public interface ICountryDal : IRepository<Country, int>, IAsyncRepository<Country, int>
{

}