using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblemB
{
    public class ValidationException :Exception
    {
        public enum ValidationExceptionType
        {

        }
        public ValidationExceptionType type;
        public ValidationException(ValidationExceptionType type,string message):base(message)
        {
            this.type=type;
        }
    }
}
