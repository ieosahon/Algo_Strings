
using System.Collections.Generic;

namespace StringAlgo
{
    public class upperCharacter
    {
        /// <summary>
        ///  A method to return all uppercase characters in a string
        /// </summary>

        public static List<char> AllUpperCharacter(string str)
        {
            List <char> upperCharacter = new List<char>();
            //char [] arrStr = str.ToCharArray();
            //for (var i = 0; i < str.Length; i++)
            foreach (char letter in str)
            {
                if (char.IsUpper(letter))
                {
                    upperCharacter.Add(letter);
                }
                //return upperCharacter;
            }
            
            return upperCharacter;
        }
    }
}