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
        const string MobileNumber = "^([91]?[ ]?)+[0-9]{10}$";
        const string Password = "^[a-zA-Z]{8,}$";
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
        /// <summary>
        /// Uc4-Validation of phone number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidationMobile(string input)
        {
            if (Regex.IsMatch(input, MobileNumber))
                return "Mobile number is Valid";
            else
                return "Mobile number is Invalid";
        }
        /// <summary>
        /// Uc5 Validation of Password
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidationPassword(string input)
        {
            if (Regex.IsMatch(input, Password))
                return "Password  matches";
            else
                return "Password failed";
        }
    }
}
