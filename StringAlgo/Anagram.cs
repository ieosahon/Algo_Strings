using System;

namespace StringAlgo
{
    public static class Anagram
    {
        public  static string WordCheck(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            string res =string.Empty;
            if(str1.Length != str2.Length) return "Not an anagram";
            
                foreach (var item in str1)
                {
                    if (!str2.Contains(item))
                    {
                        return "can not be an anagram";
                    }
                    
                }
            
             return  "the two strings are an anagram";
            
        }

        //method two for anagram
        public static string AnagramCheck(string wordA, string WordB)
        {
            // normalize and convert to char array
            char [] word1 = wordA.ToLower().ToCharArray();
            char [] word2 = WordB.ToLower().ToCharArray();

            // sort the char array
            Array.Sort(word1);
            Array.Sort(word2);

            // convert to string
            string word1A = new string(word1);
            string word1B = new string(word2);

            // compare both strings
            if (word1A == word1B)
            {
                return $"{wordA} and {WordB} are both anagram";
            }
            return $"{wordA} and {WordB} are not anagram";
        }
    }
        
}