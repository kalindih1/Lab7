using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string input = Console.ReadLine();

            bool isTrue = ValidateName(input);
            Console.WriteLine(isTrue);

            Console.WriteLine("Please enter your email");
            input = Console.ReadLine();

            isTrue = ValidateEmail(input);
            Console.WriteLine(isTrue);

            Console.WriteLine("Please enter your phone number");
            input = Console.ReadLine();

            isTrue = ValidatePhoneNumber(input);
            Console.WriteLine(isTrue);

            Console.WriteLine("Please enter the date");
            input = Console.ReadLine();

            isTrue = ValidateDate(input);
            Console.WriteLine(isTrue);


        }

        public static bool ValidateName(string input)
        {


            string name = "^[A-Z][a-z]{0,30}$";

            Regex regex = new Regex(name);

            bool isMatch = regex.IsMatch(input);

            if (isMatch == false)
            {
                Console.WriteLine("Not valid");
            }
            return isMatch;

        }
        public static bool ValidateEmail(string input)
        {


            string email = "^[A-Za-z0-9]{5,30}@+[A-Za-z0-9]{5,10}.+[A-Za-z0-9]{2,3}$";

            Regex regex = new Regex(email);

            bool isMatch = regex.IsMatch(input);

            if (isMatch == false)
            {
                Console.WriteLine("Not valid");
            }
            return isMatch;


        }
        public static bool ValidatePhoneNumber(string input)
        {


            string PhoneNumber = "^[0-9]{3}-+[0-9]{3}-+[0-9]{4}$";

            Regex regex = new Regex(PhoneNumber);

            bool isMatch = regex.IsMatch(input);

            if (isMatch == false)
            {
                Console.WriteLine("Not valid");
            }
            return isMatch;


        }

        public static bool ValidateDate(string input)
        {


            string date = "^[0-9]{1,2}/+[0-9]{1,2}/+[0-9]{4}$";

            Regex regex = new Regex(date);

            bool isMatch = regex.IsMatch(input);

            if (isMatch == false)
            {
                Console.WriteLine("Not valid");
            }
            return isMatch;


        }

    }
}
