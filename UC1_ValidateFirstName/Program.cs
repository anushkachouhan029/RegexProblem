using System;
namespace Regex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Program\n========================================");
            bool end = true;
            Console.WriteLine("1. Validate First Name\n2. End The Program");
            while (end)
            {
                Console.Write("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DataValidation validating = new DataValidation();
                        validating.ValidateFirstName();
                        break;
                    case 2:
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