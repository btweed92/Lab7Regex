using System;
using System.Text.RegularExpressions;

namespace RegularExpLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the validation program!");

                Console.WriteLine("Would you like to validate? (y/n)");

                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Please enter your First name: ");
                    string userName = Console.ReadLine();
                VerifyName(userName);

                    Console.WriteLine("Please enter email address: ");
                    string userMail = Console.ReadLine();
                VerifyEmail(userMail);

                    Console.WriteLine("Please enter your phone number (xxx-xxx-xxxx): ");
                    string userPhone = Console.ReadLine();
                VerifyPhone(userPhone);

                    Console.WriteLine("Please enter the date (MM-DD-YYYY): ");
                    string userDate = Console.ReadLine();
                VerifyDate(userDate);

                }
                else
                {
                    Console.WriteLine("Too bad, have a good day.");
                }
        }

        public static void VerifyName(string fullName)
        {
            bool goodName = Regex.IsMatch(fullName, @"^([A-Z])\w{1,30}$");

            if(goodName)
            {
                Console.WriteLine("It is good");
            }
            else
            {
                Console.WriteLine("Invalid");

            }

        }
        public static void VerifyEmail(string userEmail)
        {
            bool goodEmail = Regex.IsMatch(userEmail, @"^([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([a-z]{2,3})$");

            if (goodEmail == true)
            {
                Console.WriteLine("It is good");
            }
            else
            {
                Console.WriteLine("Invalid");

            }
        }

        public static void VerifyPhone(string phoneNum)
        {
            bool goodNum = Regex.IsMatch(phoneNum, @"^([0-9]){1,3}\-([0-9]){1,3}\-([0-9]){1,4}$");

            if (goodNum == true)
            {
                Console.WriteLine("It is good");
            }
            else
            {
                Console.WriteLine("Invalid");

            }
        }

        public static void VerifyDate(string userDate)
        {
            bool goodDate = Regex.IsMatch(userDate, @"^((0|1)\d{1})\-((0|1|2|3)\d{1})\-(\d{4})$");

            if (goodDate == true)
            {
                Console.WriteLine("It is good");
            }
            else
            {
                Console.WriteLine("Invalid");

            }
        }
    }
}
