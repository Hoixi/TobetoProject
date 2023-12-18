using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes;

public class EfCertificateDal : EfRepositoryBase<Certificate, int, TobetoContext>, ICertificateDal
{
    public EfCertificateDal(TobetoContext context) : base(context)
    {


    }
}
