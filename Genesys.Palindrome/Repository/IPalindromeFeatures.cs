using System;
using System.Collections.Generic;
using System.Text;

namespace Genesys.Palindrome.Repository
{
    public interface IPalindromeFeatures
    {
        public bool IsPalindrome(string message);
        int GetCharacterCount(string v);
        string CheckDataType(string v);
        string CheckInputType(string v);
    }
}
