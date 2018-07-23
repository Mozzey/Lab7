using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that will recognize different types of invalid input

            // VALIDATE NAMES -- format == 
            ////names can have only alphabets, should start with a capital letter, max length of 30

            // VALIDATE EMAILS -- format == 
            //// { combinations of alphanumeric chars, length between 5 and 30, no special chars}
            //// @
            //// { combo of alphanumeric, length between 5 and 10, no special charaters }
            //// .
            //// { combo of alphanumeric, length of 2 or 3 }

            // VALIDATE PHONE NUMBERS -- format == 
            //// { 3 digits } - { 3 digits } - { 4 digits }

            // VALIDATE DATE -- format ==
            //// ( dd/mm/yyyy )

            /////////////////////////////////////////
            /////////     REGEX TESTS    ////////////
            /////////////////////////////////////////

            // Name RegEx
            var nameRegex = @"^([A-Z][a-z]{0,29})$";
            // Email RegEx
            var emailRegex = @"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$";
            // Phone Number RegEx
            var phoneNumberRegex = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
            // Date RegEx
            var dateRegex = @"^\d{2}/\d{2}/\d{4}$";

            string firstName;
            string lastName;
            string fullName;
            string email;
            string phoneNumber;
            string date;

            Console.WriteLine("Please enter a Name, Email, Phone Number or Date to be validated");
            date = Console.ReadLine();
            //var validEmail = Regex.Match(email, emailRegex);
            var validDate = Regex.Match(date, dateRegex);
            Console.WriteLine(validDate);



            Console.ReadLine();
        }
    }
}
