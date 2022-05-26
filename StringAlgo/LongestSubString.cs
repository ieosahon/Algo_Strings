

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
                //var matchedLetter = Regex.Match(letter, stringPattern);
                if (char.IsLetter(letter))
                {
                    subString.Add(letter);
                }
            }
            return subString;
        }
    }
}