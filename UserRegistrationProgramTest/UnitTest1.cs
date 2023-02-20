using System.Reflection;
using System;
using UserRegistrationProblemB;
namespace UserRegistrationProgramTest
{
    [TestClass]
    public class UnitTest1
    {
        Validation Code = new Validation();
        /// <summary>
        /// Uc 10 Validation of Name
        /// </summary>
        /// <param name="input"></param>
        [TestMethod]
        [DataRow("Snehal", "Name is Valid")] // Validation of FirstName
        [DataRow("Bansod", "Name is Valid")]// Validation of LastName
        public void CheckGivenInuput_WhenAnalyseProgram_NameValidationOfString(string input,string expect)
        {
            string output = Code.ValidationName(input);
            Assert.AreEqual(expect, output);
        }

        /// <summary>
        /// Uc10 Validation of Mobile number
        /// </summary>
        /// <param name="input"></param>
        [TestMethod]
        [DataRow("915335335353","Mobile number is Valid")] //Validation of Mobile Number
        public void CheckGivenInuput_WhenAnalyseProgram_PhoneValidationOfString(string input, string expect)
        { 
            string output = Code.ValidationMobile(input);
            Assert.AreEqual(expect, output);
        }

       /// <summary>
       /// Uc10 Validation of Password
       /// </summary>
       /// <param name="input"></param>
       /// <param name="expect"></param>
        [TestMethod]
        [DataRow("ssssssssssR@", "Password  matches")] //Validation of Password
        public void CheckGivenInuput_WhenAnalyseProgram_PasswordValidationOfString(string input,string expect)
        {
            string output = Code.ValidationPassword(input);
            Assert.AreEqual(expect, output);
        }

        /// <summary>
        /// Uc10 Validation of Email
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expect"></param>
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", "Email  matches")] //Validation of email
        public void CheckGivenInuput_WhenAnalyseProgram_EmailValidationOfString(string input, string expect)
        {
            string output = Code.ValidationEmail(input);
            Assert.AreEqual(expect, output);
        }

        /// <summary>
        /// Uc 11 Pass the Email Array Vlidation
        /// </summary>
        [TestMethod]
        public void CheckGivenInuput_WhenAnalyseProgram_EmailArrayValidationOfString()
        {
            string[] input = { "abc-100@yahoo.com", "abc-100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@gmail.com.com", "abc+100@gmail.com" };

            foreach (string data in input)
            {
                string output = Code.ValidationEmail(data);
                Assert.AreEqual("Email  matches", output);
            }
            
        }
    }
}