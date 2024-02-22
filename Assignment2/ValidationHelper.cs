using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ValidationHelper
    {
        public static string Capitalize(string userInput)
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
        // Method that converts everything to lower case
        private static string ConvertToLowerCase(string userInput)
        {
            char[] chars = userInput.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.ToLower(chars[i]);
            }

            return new string (chars);
        }
        
        // Method that converts the first letter of each word
        private static string CapitalizeFirstLetters(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return userInput = " ";
            }
            // Creates an array with words after each space
            string[] words = userInput.Split(' ');

            // Runs a loop of each word and capitalizes the first letter
            for (int i = 0;i < words.Length;i++)
            {
                char[] chars = words[i].ToCharArray();
                chars[0] = char.ToUpper(chars[0]);
                words[i] = new string (chars);
            }

            // Returns the new string
            return string.Join (" ", words);
        }

        // Validates that postal code follows the pattern and reformats it accordingly
        public static bool IsValidPostalCode(string userInput, out string reformatPostalCode)
        {
            reformatPostalCode = string.Empty;

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
            
            reformatPostalCode = $"{cleanPostalCode.Substring(0,3).ToUpper()} {cleanPostalCode.Substring(3,3).ToUpper()}";
            return true;
        }

        // Validates that the province code is one in the list
        public static bool IsValidProvinceCode(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            string[] provinces = { "AB", "BC", "MB", "NB", "NL", "NT", "NS", "NU", "ON", "PE", "QC", "SK", "YT" };
            userInput = userInput.Trim().ToUpper();
            return Array.Exists(provinces, provinceCode => provinceCode.Equals(userInput));
        }

        // Validates that the phones are in required pattern
        public static bool IsValidPhoneNumber(string userInput, out string reformatPhone)
        {
            reformatPhone = string.Empty;

            if (string.IsNullOrEmpty(userInput))
            {
                return false;
            }

            string cleanPhone = new string (userInput.Where(char.IsDigit).ToArray());
            if (cleanPhone.Length != 10)
            {
                return false;
            }

            reformatPhone = $"{cleanPhone.Substring(0,3)}-{cleanPhone.Substring(3,3)}-{cleanPhone.Substring(6)}";
            return true;
        }
    }
}
