using System;
using System.Collections.Generic;
using System.Text;

namespace Day_16_17_Algorithms
{
    class MergeSort
    {
        public static void Sorting()
        {
            string[] arr = { "hi", "hello", "how", "are", "you", "pampapathi","reddy" };
            Display(arr);
            Console.WriteLine("sorted array");
            int lowValue = 0, highValue = arr.Length - 1;
            MergeSorting(arr, lowValue, highValue);
            Display(arr);
        }
        private static string[] MergeSorting(string[] arr, int lowValue, int highValue)
        {
            int midvalue;
            string[] mergeArray = new string[7];
            if (lowValue < highValue)
            {
                midvalue = lowValue + (highValue - lowValue) / 2;
                MergeSorting(arr, lowValue, midvalue);
                MergeSorting(arr, midvalue + 1, highValue);
                Merging(arr, lowValue, midvalue, highValue);
            }
            return arr;
        }
        private static string[] Merging(string[] arr, int lowValue, int midValue, int highValue)
        {
            int iValue = lowValue;
            int jValue = midValue + 1;
            int kValue = lowValue;
            string[] mergededArray = new string[7];

            while (iValue <= midValue && jValue <= highValue)
            {
                if ((arr[iValue].CompareTo(arr[jValue])) < 0)
                {
                    mergededArray[kValue] = arr[iValue];
                    iValue++;

                }
                else
                {
                    mergededArray[kValue] = arr[jValue];
                    jValue++;

                }
                kValue++;
            }
            if (iValue > midValue)
            {
                while (jValue <= highValue)
                {
                    mergededArray[kValue] = arr[jValue];
                    jValue++;
                    kValue++;
                }

            }
            else
            {
                while (iValue <= midValue)
                {
                    mergededArray[kValue] = arr[iValue];
                    iValue++;
                    kValue++;

                }
            }
            for (kValue = lowValue; kValue < highValue; kValue++)
            {
                arr[kValue] = mergededArray[kValue];

            }
            return mergededArray;
        }
        public static void Display(string[] Array)
        {
            foreach (string item in Array)
            {
                Console.WriteLine(item);
            }
        }

    }


}
