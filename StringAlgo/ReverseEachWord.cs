

using System;
using System.Text;
using System.Linq;
namespace StringAlgo
{
    public static class ReverseEachWord
    {
        public static string Reverse(string str)
        {
            //var newString = string.Empty;
           
            if (string.IsNullOrWhiteSpace(str)) return str;

            string res = string.Join(" ", str.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            return res;
            
        }
    }
}