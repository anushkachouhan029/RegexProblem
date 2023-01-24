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
            Console.WriteLine("1. Validate First Name\n2. Validate Last Name\n3. End The Program");
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