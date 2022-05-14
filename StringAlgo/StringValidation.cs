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
            Console.WriteLine("hello world");
        }

        public static List<char> AllUpperCharacter(string str)
        {
            List <char> upperCharacter = new List<char>();
            char [] arrStr = str.ToCharArray();
            //for (var i = 0; i < arrStr.Length; i++)
            foreach (char letter in arrStr)
            {
                if (char.IsUpper(letter))
                {
                    upperCharacter.Add(letter);
                }
                //return upperCharacter;
            }
            
            return upperCharacter;
        }

        public static bool IsUpperCase(string word)
        {
            return word.All(char.IsUpper);
        }

        // A method to reverse a string

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
    }

    
}