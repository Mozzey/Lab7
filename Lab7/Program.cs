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

            
            bool isRunning = true;
            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.White;
                // ================================================
                /////////////////////////////////////////
                /////////     REGEX TESTS    ////////////
                /////////////////////////////////////////
                // Name RegEx
                var nameRegex = @"^[A-Z][a-z]{0,29}$";
                // Email RegEx
                var emailRegex = @"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$";
                // Phone Number RegEx
                var phoneNumberRegex = @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
                // Date RegEx
                var dateRegex = @"^\d{2}/\d{2}/\d{4}$";
                // Matching HTML open and close tags RegEx
                var htmlRegex = @"(<[a-z1-6]{0,9}>)(</[a-z1-6]{0,9}>)";
                // ================================================

                // ask user to input data
                Console.WriteLine("Please enter a Name, Email, Phone Number or Date to be validated");
                // store the user input
                string userInput = Console.ReadLine();
                // Boolean values based on if userIput matches regular expressions
                var validName = Regex.IsMatch(userInput, nameRegex);
                var validEmail = Regex.IsMatch(userInput, emailRegex);
                var validPhoneNumber = Regex.IsMatch(userInput, phoneNumberRegex);
                var validDate = Regex.IsMatch(userInput, dateRegex);
                var validHTML = Regex.IsMatch(userInput, htmlRegex);
                // if name matches display it
                if (validName)
                {
                    DisplayIsValid(userInput);
                }
                // if email matches regex display it
                else if (validEmail)
                {
                    DisplayIsValid(userInput);
                }
                // if phone number matches regex display it
                else if (validPhoneNumber)
                {
                    DisplayIsValid(userInput);
                }
                // if date matches regex display it
                else if (validDate)
                {
                    DisplayIsValid(userInput);
                }
                // if HTML matches regex display it
                else if (validHTML)
                {
                    DisplayIsValid(userInput);
                }
                // if nothing matches inform the user
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry! {userInput} is not a valid entry!!");
                }
                // ask if user if they want to run the program again
                if (!PlayAgain())
                {
                    Console.WriteLine("Goodbye!");
                    isRunning = false;
                }
            }
        }
        // method to display valid results
        // mostly to clean up the repeating use of the the exact same two lines to display success
        private static void DisplayIsValid(string userInput)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{userInput} is a Valid entry!");
        }
        // methd to ask if the user would like to run the program again
        private static bool PlayAgain()
        {
            // try catch to handle exception a character must be input
            // in case of blank input
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                // ask the user if they would like play again
                Console.WriteLine("Would you like to enter another word to be validated? ( y/n )");
                // parse the input into a char y/n
                string yesOrNo = Console.ReadLine().ToLower();
                if (yesOrNo.StartsWith('y'))
                {
                    return true;
                }
                else if (yesOrNo.StartsWith('n'))
                {
                    return false;
                }
                else
                {
                    // if incorrect input call PlayAgain recursively
                    return PlayAgain();
                }
            }
            catch (Exception)
            {
                // // if incorrect input causes a no character exception call PlayAgain recursively
                return PlayAgain();
            }
        }
    }
}



