using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemB
{
    public class Validation
    {
        const string Name = "^[A-Z]{1}[a-z]{2,}$";
        /// <summary>
        /// Uc1 /Uc2Validation First And Last name
        /// </summary>
        /// <param name="input"></param>
        /// <param name="valueData"></param>
        /// <returns></returns>
        public string ValidationName(string input)
        {
            if (Regex.IsMatch(input, Name))
                return $"{input} is Valid";
            else
                return $"{input} is Invalid";
        }
    }
}
