using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._28
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 54, 26, 93, 17, 77, 31, 44, 55, 20 };
            quicksort(arr,0, arr.Length - 1);
        }
        //1.quicksort
        static void quicksort(int[] arr,int left,int right)
        {
            if (left < right)
            {
                int pivotpoint;
                //swap(ref arr[right], ref arr[pivot]);
                pivotpoint = partiton(arr, left, right);
                quicksort(arr, left, pivotpoint - 1);
                quicksort(arr, pivotpoint + 1, right);
            }
        }
        static int partiton(int[] arr, int left, int right)
        {
            int pivot = left;
            left++;
            while (left <= right)
            {
                if (arr[left] > arr[pivot])
                {
                    while (left < right)
                    {
                        if (arr[right] < arr[pivot])
                        {
                            
                            break;
                        }
                        else
                            right--;
                    }
                    if(left<right)
                        swap(ref arr[left], ref arr[right]);
                    right--;

                }
                else
                    left++;
            }

            swap(ref arr[pivot], ref arr[right]);
            return right;
        }
        static void swap(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
