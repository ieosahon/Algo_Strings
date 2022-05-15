using System;
using System.Collections.Generic;

namespace StringAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            StringValidation.ValidateString();
            List<char> characters = upperCharacter.AllUpperCharacter("OsahoN");

            foreach(char cha in characters)
            {
                Console.WriteLine(cha);
            }

            var res = StringValidation.IsUpperCase("Osahon");
            Console.WriteLine(res);

            var input = StringValidation.ReverseString("osahon is a nice guy");
            Console.WriteLine(input);

            var strings = StringValidation.ReverseString2("Hello world");
            Console.WriteLine(strings);

             var stringToReverse = ReverseEachWord.Reverse("osahon is");
             Console.WriteLine(stringToReverse);
        }
    }
}
