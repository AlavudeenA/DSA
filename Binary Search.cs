using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    static class Program
    {
        static int[] numbers = { 2,3,5,9,14,16,18 };
        static void Main(string[] args)
        {
            //BS(numbers, 10);
            Ceiling(numbers, 15);
        }

        static int BS(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end){
                int mid = (start + end) / 2;

                if(target < arr[mid]){
                    end = mid  - 1;
                }
                else if(target > arr[mid]){
                    start = mid  + 1;
                }
                else{
                    return mid;
                }
            }
            return -1;
        }
        static int Ceiling(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end){
                int mid = (start + end) / 2;

                if(target < arr[mid]){
                    end = mid  - 1;
                }
                else if(target > arr[mid]){
                    start = mid  + 1;
                }
                else{
                    return mid;
                }
            }
            return start;
        }
         static int Flooring(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end){
                int mid = (start + end) / 2;

                if(target < arr[mid]){
                    end = mid  - 1;
                }
                else if(target > arr[mid]){
                    start = mid  + 1;
                }
                else{
                    return mid;
                }
            }
            return -1;
        }
    }
}
