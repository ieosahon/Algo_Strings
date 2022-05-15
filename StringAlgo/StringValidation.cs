using System;
using StringAlgo;
using System.Collections.Generic;
using System.Linq;

namespace StringAlgo
{
    public static class StringValidation
    {
        public static void ValidateString()
        {
            //Console.WriteLine("hello world");
        }

        public static bool IsUpperCase(string word)
        {
            return word.All(char.IsUpper);
        }

        /// <summary>
        /// A method to reverse a string
        /// </summary>
        public static string ReverseString(string str)
        {
            var newStr = string.Empty;
            if (string.IsNullOrEmpty(str)) return str;

            for (var i = str.Length-1; i >= 0; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }

         public static string ReverseString2(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;
            str = str.Replace(",", "");
            char [] arrStr = str.ToCharArray();
            Array.Reverse(arrStr);
            return new String(arrStr);
           
        }
    }
       
}