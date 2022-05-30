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
 System.Console.WriteLine("################################");
            var res = StringValidation.IsUpperCase("Osahon");
            Console.WriteLine(res);
             System.Console.WriteLine("################################");

            var input = StringValidation.ReverseString("osahon is a nice guy");
            Console.WriteLine(input);

            var strings = StringValidation.ReverseString2("Hello world");
            Console.WriteLine(strings);

             var stringToReverse = ReverseEachWord.Reverse("osahon is");
             Console.WriteLine(stringToReverse);

             int [] arrNum = {1, 4, 5, 7, 10};
             int givenNum = 4;
             Console.WriteLine(LinearSearch.SearchForNumber(arrNum, givenNum));
              Console.WriteLine(LinearSearch.SearchForNumber2(arrNum, givenNum));

            var str1 = "aedlove";
            var str2 = "ADEvoel";
            Console.WriteLine(Amagram.WordCheck(str1, str2));

            System.Console.WriteLine("################################");


            
            List<char> stringToCheck = LongestSubString.SubString("qweQAsf1234@#$%^&!_");
              foreach(var i in stringToCheck)
              {
                  Console.WriteLine(i);
              }
            System.Console.WriteLine("################################");

            var str = LongestSubString.SubStrings("qweQAsf1234@#$%^&!_");
           
            Console.WriteLine(str);
            
        }
    }
}
