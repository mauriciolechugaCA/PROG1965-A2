using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class ValidationHelper
    {
        public static string Capitalize(string userInput)
        {
            userInput = userInput ?? string.Empty;
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

        //private static bool IsValidPostalCode(string userInput)
        //{
        //    return true;
        //}

        //private static bool IsValidProvinceCode(string userInput)
        //{
        //    return true;
        //}

        //private static bool IsValidPhoneNumber(string userInput)
        //{
        //    return true;
        //}

    }
}
