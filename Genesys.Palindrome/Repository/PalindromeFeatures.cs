using System;
using System.Collections.Generic;
using System.Text;

namespace Genesys.Palindrome.Repository
{
    public class PalindromeFeatures : IPalindromeFeatures
    {
        /// <summary>
        /// Check input type is word or sentence
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CheckInputType(string input)
        {
            var isWord = input.Contains(' ');
            if (isWord)
            {
                return "Given input type is an sentence";
            }
            else
            {
                return "Given input type is a word";
            }
        }
        
        /// <summary>
        /// Check what is the datatype of the input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CheckDataType(string input)
        {
            var inputType = string.Empty;

            if (Int32.TryParse(input, out _))
            {
                inputType = input + "is integer type";
            }
            else if (double.TryParse(input, out _))
            {
                inputType = input + "is floating point type";
            }
            else if (char.TryParse(input, out _))
            {
                inputType = input + " is character type";
            }
            else 
            {
                inputType = input + "  is string type";
            }

            return inputType;
        }

        /// <summary>
        /// check the Character count of the input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetCharacterCount(string input)
        {
            return input.Length;
        }

        /// <summary>
        /// Check given input is palindrome or not
        /// </summary>
        /// <param name="message"></param>
        /// <returns>boolean</returns>
        public bool IsPalindrome(string message)
        {
            bool isPalindrome = false;

            string reverse = string.Empty;

            for (int index = message.Length-1; index >= 0; index--)
            {
                reverse += message[index].ToString();
            }

            if (reverse.Equals(message))
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
