using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_17_Algorithms
{
    class StringPermutation
    {
        public static void permute(String str,int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    permute(str, l + 1, r);
                    str = Swap(str, l, i);
                }
            }
        }
        /// swapping method  string


        public static string Swap(string inputword, int l, int i)
        {
            char temp;
            char[] charArray = inputword.ToCharArray();
            temp = charArray[l];
            charArray[l] = charArray[i];
            charArray[i] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
