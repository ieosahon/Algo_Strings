

using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StringAlgo
{
    public static class LongestSubString
    {
        public static List<char> SubString(string str)
        {

            List<char> subString = new List<char>();
            foreach (var letter in str)
            {

                if (char.IsLetter(letter))
                {
                    subString.Add(letter);
                }
            }
            return subString;
        }

        // another method
        public static string SubStrings(string str)
        {
            var str1 = string.Empty;
            foreach(var n in str)
            {
                if(char.IsLetter(n))
                {
                    str1 = str1 + n;
                }
            }
            return str1;
        }
    }
}