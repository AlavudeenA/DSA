using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rec
{
    static class Program
    {
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static int numberToBeFound = 9;
        static int digit = 12548;
        static int sum = 0;
        static void Main(string[] args)
        {
            var result = SumOfArray(numbers, 0 , numbers.Length - 1);
            //PrintAscDes(5);
            //int result = fib(4);
            //int result = BS(0, numbers.Length - 1);
            //int result = SumofD(digit);
            //ReverseD(digit);
            //int result = countStepsForZero(8, 0);
            //bool result = FindIfArrayIsSorted(arr, 0);
            int[] arr = { 5, 4, 3, 2, 1 };
            //TriangleStar(4, 0);
            //Bubble(arr, arr.Length - 1, 0);
            //Selection(arr, arr.Length, 0, 0);
            //MergeSort(arr);
            //MergeSortInPlace(arr, 0, arr.Length);
            QSort(arr, 0 , arr.Length - 1);
            Console.WriteLine(string.Join("\n", arr));
        }

        static void QSort(int[] nums, int low, int hi){

            if(low >= hi) {
                return;
            }

            int s = low;
            int e = hi;
            int m = (s + e)/2;
            int pivot = nums[m];

            while(s <= e) {
                while(nums[s] < pivot) {
                    s++;
                }
                while(nums[e] > pivot) {
                    e--;
                }

                if(s <= e)
                {
                    int temp = nums[s];
                    nums[s] = nums[e];
                    nums[e] = temp;
                    s++;
                    e--;
                }
            }

            QSort(nums, low, e);
            QSort(nums, s, hi);
        }

        static int SumOfArray(int[] arr, int s, int e)
        {
            if (s == arr.Length - 1)
                return arr[s];
            return arr[s] + SumOfArray(arr, s + 1, arr.Length - 1);
        }
        static void Print(int n)
        {
            if (n == 0)
                return;

            Print(n - 1);
            Console.WriteLine(n);
        }
        static void PrintDes(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(n);
            PrintDes(n - 1);
        }
        static void PrintAscDes(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(n);
            PrintAscDes(n - 1);
            Console.WriteLine(n);
        }

        static void MergeSortInPlace(int[] arr, int s, int e)
        {
            if (e - s == 1) return;

            int m = (s + e) / 2;

            MergeSortInPlace(arr, s, m);

            MergeSortInPlace(arr, m, e);

            DoSortInPlace(arr, s, m, e);
        }

        private static void DoSortInPlace(int[] arr, int s, int m, int e)
        {
            int i = s; int j = m; int k = 0;
            int[] mix = new int[e - s];
            while (i < m && j < e)
            {
                if (arr[i] < arr[j])
                {
                    mix[k] = arr[i];
                    i = i + 1;
                }
                else
                {
                    mix[k] = arr[j];
                    j = j + 1;
                }

                k = k + 1;
            }

            while (i < m)
            {
                mix[k] = arr[i];
                i = i + 1;
                k = k + 1;
            }

            while (j < e)
            {
                mix[k] = arr[j];
                j = j + 1;
                k = k + 1;
            }

            for (int l = 0; l < mix.Length; l++)
            {
                arr[s + l] = mix[l];
            }
        }
        static int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1) return arr;

            int m = arr.Length / 2;

            int[] left = MergeSort(arr[0..m]);

            int[] right = MergeSort(arr[m..arr.Length]);

            return DoSort(left, right);
        }

        private static int[] DoSort(int[] left, int[] right)
        {
            int i = 0; int j = 0; int k = 0;
            int[] sortedArray = new int[left.Length + right.Length];
            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    sortedArray[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    sortedArray[k] = right[j];
                    j = j + 1;
                }

                k = k + 1;
            }

            while (i < left.Length)
            {
                sortedArray[k] = left[i];
                i = i + 1;
                k = k + 1;
            }

            while (j < right.Length)
            {
                sortedArray[k] = right[j];
                j = j + 1;
                k = k + 1;
            }

            return sortedArray;
        }

        static void TriangleStar(int r, int c)
        {
            if (r == 0) return;
            if (c < r)
            {
                Console.Write("*");
                TriangleStar(r, ++c);
            }
            else
            {
                Console.WriteLine();
                TriangleStar(--r, 0);
            }
        }
        static void Bubble(int[] arr, int r, int c)
        {
            if (r == 0) return;
            if (c < r)
            {
                if(arr[c] > arr[c+1]) {
                    int temp = arr[c + 1];
                    arr[c + 1] = arr[c];
                    arr[c] = temp;
                }
                Bubble(arr, r, ++c);
            }
            else
            {
                Bubble(arr, --r, 0);
            }
        }

        static void Selection(int[] arr, int r, int c, int max)
        {
            if (r == 0) return;
            if (c < r)
            {
                if (arr[c] > arr[max])
                    Selection(arr, r, c + 1, c);
                else
                    Selection(arr, r, c + 1, max);
            }
            else
            {
                int temp = arr[max];
                arr[max] = arr[r - 1];
                arr[r - 1] = temp;
                Selection(arr, r - 1, 0, 0);
            }
        }

        static int LinearSearch(int[] arr, int target, int index)
        {
            if (arr.Length - 1 == index)
                return -1;

            if (arr[index] != target)
                return LinearSearch(arr, target, index = index + 1);

            return index;
        }

        static bool FindIfArrayIsSorted(int[] arr, int index)
        {
            if (arr.Length - 1 == index)
            {
                return true;
            }
            return arr[index] < arr[index + 1] && FindIfArrayIsSorted(arr, index = index + 1);
        }

        static int countStepsForZero(int digit, int steps)
        {
            if (digit == 1)
            {
                steps = steps + 1;
                return steps;
            }

            if (digit % 2 == 0)
                return countStepsForZero(digit / 2, steps + 1);
            else
                return countStepsForZero(digit - 1, steps + 1);
        }

        static int SumofD(int digit)
        {
            int lastNumberInDigit = digit % 10;
            int numberWithOutItsLastNumber = digit / 10;
            if (numberWithOutItsLastNumber <= 0)
                return digit;
            return lastNumberInDigit + SumofD(numberWithOutItsLastNumber);
        }

        static void ReverseD(int digit) // outside value is updated, hence no need to return value; number is palindrome if n == ReverseD(n);
        {
            int lastNumberInDigit = digit % 10;
            int numberWithItsLastNumber = digit / 10;
            if (digit == 0)
                return;
            sum = sum * 10 + lastNumberInDigit;
            ReverseD(numberWithItsLastNumber);
        }

        static int BS(int start, int end)
        {
            int mid = (start + end) / 2;

            if (numberToBeFound == numbers[mid])
                return mid;

            if (numberToBeFound < numbers[mid])
                return BS(start, mid - 1);
            else
                return BS(mid + 1, numbers.Length - 1);
        }

        static int fib(int n)
        {
            if (n < 2)
                return n;
            return fib(n - 1) + fib(n - 2);
        }
    }
}
