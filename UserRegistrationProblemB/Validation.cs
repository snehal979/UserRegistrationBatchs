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
        const string Password = "^[a-z]{8,}([A-Z0-9]{1,})(@)$";
       //const string Email = "^[abc]+[.]{0,1}[a-zA-Z0-9]+[@][bl]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        const string Email1 = "^[a-zA-Z0-9]+[-.+_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        /*abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl
         * & co) and 2 optional (xyz & in) with precise @ and . positions*/

        //Default constructor
        public Validation()
        {
          
        }
        //Parameterised Constructor pass array of email
        string[] inputP;
        public Validation(string[] input)
        {
            this.inputP = input;
        }
        /// <summary>
        /// Uc1 /Uc2Validation First And Last name
        /// </summary>
        /// <param name="input"></param>
        /// <param name="valueData"></param>
        /// <returns></returns>
        public string ValidationName(string input)
        {
            try
            {
                if (input.Equals(string.Empty))
                    throw new ValidationException(ValidationException.ValidationExceptionType.EMPTY_NAME, "Name is Empty");
                else if (Regex.IsMatch(input, Name))
                    return "Name is Valid";
                else
                    return "Name is Invalid";
            }
            catch (NullReferenceException)
            {
                throw new ValidationException(ValidationException.ValidationExceptionType.NULL_NAME, "Name is null");

            }
        }
        /// <summary>
        /// Uc4-Validation of phone number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidationMobile(string input)
        {
            try
            {
                if (input.Equals(string.Empty))
                    throw new ValidationException(ValidationException.ValidationExceptionType.EMPTY_MOBILE, "Mobile number is Empty");
                else if (Regex.IsMatch(input, MobileNumber))
                    return "Mobile number is Valid";
                else
                    return "Mobile number is Invalid";
            }
            catch (NullReferenceException)
            {
                throw new ValidationException(ValidationException.ValidationExceptionType.NULL_MOBILE, "Mobile number is null");

            }
        }
        /// <summary>
        /// Uc5, 6,7,8 Validation of Password
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidationPassword(string input)
        {
            try
            {
                if (input.Equals(string.Empty))
                    throw new ValidationException(ValidationException.ValidationExceptionType.EMPTY_PASSWORD, "Password is Empty");
                else if (Regex.IsMatch(input, Password))
                    return "Password  matches";
                else
                    return "Password failed";
            }
            catch (NullReferenceException)
            {
                throw new ValidationException(ValidationException.ValidationExceptionType.NULL_PASSWORD, "Password is null");

            }
        }
        /// Uc3 -Validation of Email
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidationEmail(string input)
        {
            try
            {
                if (input.Equals(string.Empty))
                    throw new ValidationException(ValidationException.ValidationExceptionType.EMPTY_EMAIL, "Email is Empty");
                else if (Regex.IsMatch(input, Email1))
                    return "Email  matches";
                else
                    return "Email failed";
            }
            catch (NullReferenceException)
            {
                throw new ValidationException(ValidationException.ValidationExceptionType.NULL_EMAIL, "Email is null");

            }
        }
        /// <summary>
        /// Uc9 ArrayPass Of Email Validation // Changes with Constructor
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void ValidationEmailArray()
        {
            foreach(var data in this.inputP)
            {
                Console.WriteLine(ValidationEmail(data)); 
            }
        }
        /// <summary>
        /// Uc13 Lambda Expression validation of Name,Mobile,Password,Email
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidationName_Lambda(string input) => Regex.IsMatch(input,Name) ? "Name is Valid":"Name is Invalid";
        public string ValidationMobile_Lambda(string input) => Regex.IsMatch(input,MobileNumber) ? "Mobile is Valid" : "Mobile is Invalid";
        public string ValidationPassword_Lambda(string input) => Regex.IsMatch(input,Password) ? "Password is Valid" : "Password is Invalid";
        public string ValidationEmail_Lambda(string input) => Regex.IsMatch(input,Email1) ? "Email is Valid" : "Email is Invalid";
    }
}
