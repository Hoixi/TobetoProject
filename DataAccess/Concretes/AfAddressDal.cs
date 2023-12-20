using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class AfAddressDal : EfRepositoryBase<Address, int, TobetoContext>, IAddressDal
{
    public AfAddressDal(TobetoContext context) : base(context)
    {


    }
}
