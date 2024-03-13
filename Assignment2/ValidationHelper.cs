using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2
{
    internal class ValidationHelper
    {
        protected ValidationHelper() { } // Added 'protected' because VSCode suggested it. Don't know why.

        public static string Capitalize(string userInput)   // Validates that there is no empty input.
                                                            // Formats the input and returns it.
        {
            if (userInput == null)
                {
                    userInput = " ";
                }
            userInput = userInput.Trim();
            userInput = ConvertToLowerCase(userInput);
            userInput = CapitalizeFirstLetters(userInput);
            
            return userInput;
        }

        private static string ConvertToLowerCase(string userInput)  // Converts to lower for easier comparison
        {
            char[] chars = userInput.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.ToLower(chars[i]);
            }

            return new string (chars);
        }
        
        private static string CapitalizeFirstLetters(string userInput)  // Capitalizes the first letter of every word.
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return " ";
            }

            string[] words = userInput.Split(' ');

            for (int i = 0;i < words.Length;i++)
            {
                char[] chars = words[i].ToCharArray();
                chars[0] = char.ToUpper(chars[0]);
                words[i] = new string (chars);
            }

            return string.Join (" ", words);
        }

        public static bool IsValidPostalCode(string userInput, out string formattedPostalCode)  // Formats code to 'X0X 0X0' pattern
        {
            formattedPostalCode = string.Empty;

            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            string cleanPostalCode = userInput.Replace(" ", "");
            Regex regex = new Regex(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$");
            
            if (!regex.IsMatch(cleanPostalCode))
            {
                return false;
            }

            formattedPostalCode = $"{cleanPostalCode.Substring(0, 3).ToUpper()} {cleanPostalCode.Substring(3, 3).ToUpper()}";
            return true;
        }

        public static bool IsValidProvinceCode(string userInput)    // Checks that code exists in the list
                                                                    // and returns capitalized.
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }
            
            userInput = userInput.Trim().ToUpper();
            string[] provinces = { "AB", "BC", "MB", "NB", "NL", "NT", "NS", "NU", "ON", "PE", "QC", "SK", "YT" };
            return Array.Exists(provinces, provinceCode => provinceCode.Equals(userInput));
        }

        public static bool IsValidPhoneNumber(string userInput, out string formattedPhone)  // Checks that is a valid number
                                                                                            // and formats to the correct pattern.
        {
            formattedPhone = string.Empty;

            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            string cleanPhone = new string (userInput.Where(char.IsDigit).ToArray());
            if (cleanPhone.Length != 10)
            {
                return false;
            }

            formattedPhone = $"{cleanPhone.Substring(0, 3)}-{cleanPhone.Substring(3, 3)}-{cleanPhone.Substring(6)}";
            return true;
        }

        public static bool IsEmailValid(string userInput, out string formattedEmail)    // Checks that email is in valid format
        {
            formattedEmail = string.Empty;
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            else if (!regex.IsMatch(userInput))
            {
                return false;
            }
            else
            {
                formattedEmail = userInput.ToLower().Trim();
                return true;
            }

        }

        public static bool IsYearValid(string userInput)    // Method that checks that year is current + 1
        {
            if (int.TryParse(userInput, out int validYear))
            {
                int currentYear = DateTime.Now.Year;
                return validYear >= 1900 && validYear <= currentYear + 1;
            }

            return false;
        }

        public static bool IsDateFuture(DateTime selectedDate)  // Method that validates if date picked is in the future
        {
            return selectedDate >= DateTime.Now;
        }
    }
}
