using Core.DataAccess.Repositories;
using Core.Entities.Concretes;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfUserDal : EfRepositoryBase<User, int, TobetoContext>, IUserDal
    {
        TobetoContext _tobetoContext;
        public EfUserDal(TobetoContext context) : base(context)
        {
            _tobetoContext = context;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            
                var result = from operationClaim in _tobetoContext.OperationClaims
                             join userOperationClaim in _tobetoContext.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            
        }
    }
}
