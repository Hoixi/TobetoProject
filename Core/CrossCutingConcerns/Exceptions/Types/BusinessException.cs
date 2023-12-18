using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCutingConcerns.Types
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {

        }

    }
}
