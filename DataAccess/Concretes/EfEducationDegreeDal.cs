using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfEducationDegreeDal : EfRepositoryBase<EducationDegree, int, TobetoContext>, IEducationDegreeDal
    {
        public EfEducationDegreeDal(TobetoContext context) : base(context)
        {


        }
    }
}
