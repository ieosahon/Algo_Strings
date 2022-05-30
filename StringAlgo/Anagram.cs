using System;

namespace StringAlgo
{
    public static class Amagram
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
    }
}