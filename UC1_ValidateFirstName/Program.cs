using System;
namespace Regex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program\n========================================");
            DataValidation validating = new DataValidation();
            bool end = true;
            Console.WriteLine("1. Validate First Name\n2. Validate Last Name\n3. Validate Email\n4. End The Program");
            while (end)
            {
                Console.Write("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        validating.ValidateFirstName();
                        break;
                    case 2:
                        validating.ValidateLastName();
                        break;
                    case 3:
                        validating.ValidateEmail("abc.xyz@bl.co.in");
                        validating.ValidateEmail("abc111@abc.com");
                        validating.ValidateEmail("abc@bl.co");
                        validating.ValidateEmail("abc1232.com");
                        break;
                    case 4:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }
            }
        }
    }
}