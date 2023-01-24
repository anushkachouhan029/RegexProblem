using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex01
{
    public class DataValidation
    {
        public Regex First_Name_Regex = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public Regex Last_Name_Regex = new Regex(@"^[A-Z]{1}[A-Za-z]{2,}?$");
        public void ValidateFirstName()
        {
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();

            if (First_Name_Regex.IsMatch(firstName))
            {
                Console.WriteLine("The First Name Is Valid ");
            }
            else
            {
                Console.WriteLine("The First Name Is Not Valid");
            }
        }
        public void ValidateLastName()
        {
            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();

            if (Last_Name_Regex.IsMatch(lastName))
            {
                Console.WriteLine("The Last Name Is Valid ");
            }
            else
            {
                Console.WriteLine("The Last Name Is Not Valid");
            }
        }
    }

}