using System.Reflection;
using System;
using UserRegistrationProblemB;
using Microsoft.VisualStudio.TestPlatform.Utilities;

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
        [DataRow("","Name is Empty")]  //Uc12 Pass Invalid Input Give Exception(Empty)
        [DataRow(null,"Name is null")] // //Uc12 Pass Invalid Input Give Exception(null)
        public void CheckGivenInuput_WhenAnalyseProgram_NameValidationOfString(string input,string expect)
        {
            try
            {
                string output = Code.ValidationName(input);
                Assert.AreEqual(expect, output);
            }
            catch(ValidationException ex)
            {
                Assert.AreEqual(expect, ex.Message);
            }
        }

        /// <summary>
        /// Uc10 Validation of Mobile number
        /// </summary>
        /// <param name="input"></param>
        [TestMethod]
        [DataRow("915335335353","Mobile number is Valid")] //Validation of Mobile Number
        [DataRow("", "Mobile number is Empty")]  //UC12 Pass Invalid Input Give Exception(Empty)
        [DataRow(null, "Mobile number is null")] // //Uc12 Pass Invalid Input Give Exception(null)
        public void CheckGivenInuput_WhenAnalyseProgram_PhoneValidationOfString(string input, string expect)
        {
            try
            {
                string output = Code.ValidationMobile(input);
                Assert.AreEqual(expect, output);
            }
            catch(ValidationException ex)
            {
                Assert.AreEqual(expect, ex.Message);
            }
        }

       /// <summary>
       /// Uc10 Validation of Password
       /// </summary>
       /// <param name="input"></param>
       /// <param name="expect"></param>
        [TestMethod]
        [DataRow("ssssssssssR@", "Password  matches")] //Validation of Password
        [DataRow("", "Password is Empty")]  //Uc12 Pass Invalid Input Give Exception(Empty)
        [DataRow(null, "Password is null")] // //Uc12 Pass Invalid Input Give Exception(null)
        public void CheckGivenInuput_WhenAnalyseProgram_PasswordValidationOfString(string input,string expect)
        {
            try
            {
                string output = Code.ValidationPassword(input);
                Assert.AreEqual(expect, output);
            }
            catch(ValidationException ex)
            {
                Assert.AreEqual(expect, ex.Message);
            }
        }

        /// <summary>
        /// Uc10 Validation of Email
        /// </summary>
        /// <param name="input"></param>
        /// <param name="expect"></param>
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in", "Email  matches")] //Validation of email
        [DataRow("", "Email is Empty")]  //Uc12 Pass Invalid Input Give Exception(Empty)
        [DataRow(null, "Email is null")] // //Uc12 Pass Invalid Input Give Exception(null)
        public void CheckGivenInuput_WhenAnalyseProgram_EmailValidationOfString(string input, string expect)
        {
            try
            {
                string output = Code.ValidationEmail(input);
                Assert.AreEqual(expect, output);
            }
            catch(ValidationException ex)
            {
                Assert.AreEqual(expect, ex.Message);
            }
            
        }

        /// <summary>
        /// Uc 11 Pass the Email Array Validation Parameterised Constructor pass array of email
        /// </summary>
        [TestMethod]
        public void CheckGivenInuput_WhenAnalyseProgram_EmailArrayValidationOfString()
        {
            string[] input = { "abc-100@yahoo.com", "abc-100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@gmail.com.com", "abc+100@gmail.com" };
            Validation Code1 = new Validation(input);
            foreach (string data in input)
            {
                string output = Code1.ValidationEmail(data);
                Assert.AreEqual("Email  matches", output);
            }
        }
    }
}