using System;

namespace Day_16_17_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to algorithm");
            Console.WriteLine("Press 1 for Permutation problem statement");
            Console.WriteLine("Press 2 for Binary search in a word list");
            Console.WriteLine("Press 3 for insertion sort in a word list");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    StringPermutation stringPermutation = new StringPermutation();
                    String str = "ABC";
                    int n = str.Length;
                    StringPermutation.permute(str, 0, n - 1);

                    break;
                case 2:
                    //binary search a word from word list
                    BinarySearchWord.BinarySearch();
                    break;
                case 3:
                    InsertionSort.sort();
                    break;

                default:
                    Console.WriteLine("invalid selection made!!");
                    Console.WriteLine("Enter a valid option: ");
                    break;
            }
        }
    }
}
