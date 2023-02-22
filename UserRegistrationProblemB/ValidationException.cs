using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblemB
{
    public class ValidationException : Exception
    {
        public enum ValidationExceptionType
        {
            EMPTY_NAME,
            EMPTY_MOBILE,
            NULL_NAME,
            NULL_MOBILE,
            EMPTY_PASSWORD,
            NULL_PASSWORD,
            EMPTY_EMAIL,
            NULL_EMAIL
        }
        public ValidationExceptionType type;
        public ValidationException(ValidationExceptionType type,string message):base(message)
        {
            this.type=type;
        }
    }
}
