
using System;
using System.Collections.Generic;

namespace StringAlgo
{
public static class DuplicateChar
{
    public static string DuplicateCharater(string str)
    {
        string res = "";
        var charArray = str.ToCharArray();
        var charDictionary = new Dictionary<char, int>();

        foreach (var ch in charArray)
        {
            if (charDictionary.ContainsKey(ch))
            {
                charDictionary[ch]++;
            }
            else
            {
                charDictionary.Add(ch, 1);
            }
        }
        foreach (var item in charDictionary)
        {
            if (item.Value > 1)
            {
                res = item.Key.ToString();
            }
        }
        return res;
    }

    //
    // public static string DupChar(string str)
    // {
    //     char [] words = str.ToCharArray();
    //     for (int i =0; i < words.Length-1; i++)
    //     {
    //         if (words[i] == words[i+1])
    //         {
                
    //         }
    //     }
    // }
}
}
