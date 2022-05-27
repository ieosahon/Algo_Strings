using System;

namespace StringAlgo
{
        public static class Amagram
{
    public  static string WordCheck(string str1, string str2)
    {
        str1 = str1.ToLower();
        str2 = str2.ToLower();

        string res = "no";
        if ((str1.Length == str2.Length) && (string.Equals(str1, str2)  ))
        {
            //return $"words can not be arrrange to be the same"; 
            res = "yes";
        }

            
        
        return res;
    }
}
}