using System;
using System.Collections.Generic;

namespace StringAlgo
{
    public static class LinearSearch
    {
        public static int SearchForNumber(int [] arrNum, int k)
        {
            int arrLen = arrNum.Length;
            if (arrNum == null || arrLen == 0 ) return 0;
            foreach(var num in arrNum)
            {
                if (num == k)
                {
                    return k;
                }
            }
            return -1;
        }

        public static int SearchForNumber2(int [] arrNum, int k)
        {
            int item = Array.Find(arrNum, item => item == 19) ;
            return item;
        }
    }
}