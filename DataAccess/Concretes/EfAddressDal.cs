using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfAddressDal : EfRepositoryBase<Address, int, TobetoContext>, IAddressDal
{
    public EfAddressDal(TobetoContext context) : base(context)
    {


    }
}
