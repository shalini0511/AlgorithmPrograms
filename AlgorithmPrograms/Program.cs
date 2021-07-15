﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmPrograms
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Permutation Using Recursion");
                Console.WriteLine("2.Binary Search the word from wordlist");
                Console.WriteLine("3.Insertion Sort");
                Console.WriteLine("4.Bubble Sort");
                Console.WriteLine("5.Merge sort");
                Console.WriteLine("6.Anagram Problem");
                Console.WriteLine("7.Prime number in range");
                Console.WriteLine("8.Prime numbers with anagrams and palindrome");
                Console.WriteLine("9.Think Number using binary search concept");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter String to find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutations.Permutate(str, 0, n - 1);
                        break;
                    case 2:
                        string txtpath = File.ReadAllText(@"C:\Users\Radhika\source\repos\AlgorithmPrograms1\ListOfWords.txt");
                        List<string> words = new List<string>(txtpath.Split(" "));
                        words.Sort();
                        BinarySearch<string> binarySearch = new BinarySearch<string>();
                        binarySearch.BinarySearchWord(words);
                        break;
                    case 3:
                        InsertionSort<int> insertionSort = new InsertionSort<int>();
                        int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                        insertionSort.Sort(arr);
                        insertionSort.PrintArray(arr);
                        break;
                    case 4:
                        int[] arr1 = { 10, 2, 14, 3, 1, 5, 9 };
                        BubbleSort<int> bubbleSort = new BubbleSort<int>();
                        bubbleSort.BubbleSortInArray(arr1);
                        bubbleSort.PrintArray(arr1);
                        break;
                    case 5:
                        int[] arr2 = { 32, 12, 9, 65, 24, 5 };
                        MergeSort.Sort(arr2, 0, arr2.Length - 1);
                        MergeSort.PrintArray(arr2);
                        break;
                    case 6:
                        Anagram.FindAnagram();
                        break;
                    case 7:
                        Console.WriteLine("The prime numbers are : ");
                        PrimeNumInRange primeNum = new PrimeNumInRange();
                        primeNum.FindPrime();
                        break;
                    case 8:
                        Console.WriteLine("Enter First number:");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Number :");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        int res1 = PrimeNumExtended.FindPrime(num1);
                        int res2 = PrimeNumExtended.FindPrime(num2);
                        bool anagramRes = PrimeNumExtended.FindAnagram(Convert.ToString(num1), Convert.ToString(num2));
                        bool palindormres = PrimeNumExtended.IsPalindrome(num1);
                        if (anagramRes)
                        {
                            Console.WriteLine("both values are anagrams");

                        }
                        else
                        {
                            Console.WriteLine("both the values are not anagrams");
                        }
                        if (palindormres)
                        {
                            Console.WriteLine("Number is palindrome");
                        }
                        else
                        {
                            Console.WriteLine("Number is not a palindrome");
                        }
                        break;
                    case 9:
                        GuessNumber.ThinkNumber();
                        break;

                    default:
                        Console.WriteLine("Enter the valid option!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag = Console.ReadLine();
            }






        }
       
    }
}
