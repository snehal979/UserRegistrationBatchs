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
                    Console.WriteLine("hint 1.FirstName 2.Last name 3.Exit");
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
