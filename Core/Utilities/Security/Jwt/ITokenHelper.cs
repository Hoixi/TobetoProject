using Core.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        
        AccessToken CreateToken(UserBase user, List<OperationClaim> operationClaims);
    }
}
