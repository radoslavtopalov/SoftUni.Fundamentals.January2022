using System;
using System.Text.RegularExpressions;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsValid(Console.ReadLine());
        }

        private static void IsValid(string str)
        {
            var isLengthValid = str.Length >= 6 && str.Length <= 10;

            var isWithLettersAndDigitsOnly = Regex.IsMatch(str, @"^[a-zA-Z0-9]+$");
            //var isWithLettersAndDigitsOnly = str.All(Char.IsLetterOrDigit);

            var isWithAtLeastTwoDigits = Regex.IsMatch(str, @"^(?=.*\d{2,})");
            // (?=.*\d{2,}) this part saying except at least 2 digits - https://stackoverflow.com/questions/19491670/regular-expression-for-password-at-least-2-digits-and-one-special-character-and

            if (isLengthValid && isWithLettersAndDigitsOnly && isWithAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
                return;
            }

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isWithLettersAndDigitsOnly)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isWithAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}