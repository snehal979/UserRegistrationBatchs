namespace UserRegistrationProblemB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("User Registration Program");
            Validation code = new Validation();
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("hint 1.FirstName 2.Last name 3.Mobile number 4.Password 5.Email 6.EmailArray Validation7.Exit");
                    int num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("Enter the first name");//"Snehal"
                            string firstName = Console.ReadLine();
                            Console.WriteLine("FirstName :"+code.ValidationName(firstName));
                            break;
                        case 2:
                            Console.WriteLine("Enter the Last name");//"Bansod"
                            string lastName = Console.ReadLine();
                            Console.WriteLine("LastName :"+code.ValidationName(lastName));
                            break;
                        case 3:
                            Console.WriteLine("Enter the number");
                            string number = Console.ReadLine();//911111111111//91 1111111111//1111111111
                            Console.WriteLine(code.ValidationMobile(number));
                            break;
                        case 4:
                            Console.WriteLine("Enter the password");
                            string password = Console.ReadLine();//ssssssssssR@
                            Console.WriteLine(code.ValidationPassword(password));
                            break;
                        case 5:
                            Console.WriteLine("Enter the email");
                            //sstring email = Console.ReadLine();
                            Console.WriteLine(code.ValidationEmail("abc.xyz@bl.co.in"));
                            break;
                        case 6:
                            string[] emalsArray = { "abc-100@yahoo.com", "abc-100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
                            Validation code1 = new Validation(emalsArray);
                            code1.ValidationEmailArray(); 
                            break;
                        case 7:
                            flag = false;
                            Console.WriteLine("Thank you");
                            break;
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
