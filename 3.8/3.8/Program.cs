using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {

            Program pg=new Program();

            int[] score1 = new int[10] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66 };
            int[] score2 = new int[10] { 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };
            int[] score3 = new int[8] { 5, 4, 3, 2,1,2,3,4};
            int[] sort = new int[20];
            int[] s = new int[20] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66 , 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };


            mergesort2(s,sort);

            //mergesort(s);
            
            

            for (int i = 0; i < sort.Length; ++i)
                Console.Write(sort[i] + " ");


            /*
            SelectionSort(score1);
            SelectionSort(score2);

            s = merge(score1, score2);

            for (int i = 0; i < s.Length; ++i)
                Console.Write(s[i] + " ");
              */
        }

    

       

        //1.merge
        static void merge(int[] arr1, int[] arr2, int[] sort)
        {
            int i=0,j=0,k=0;

            while (k < arr2.Length && j < arr1.Length)
            {
                if (arr1[j] <= arr2[k])
                {
                    sort[i++] = arr1[j++];

                }
                else
                {
                    sort[i++] = arr2[k++];

                }

            }
            if (j < arr1.Length)
            {
                while (j < arr1.Length)
                {
                    sort[i++] = arr1[j++];
                }

            }
            else if (k < arr2.Length)
            {
                while (k < arr2.Length)
                {
                    sort[i++] = arr2[k++];
                }

            }


           

        }


        //2.method
        public static int Plus(int a, int b)
        {
            int result = a + b;
            return result; 
        }

        
        public static void Swap(ref int a,ref int b)
        {
            int temp;
            temp = b;
            b = a;
            a = temp;
        }

        public static void SelectionSort(int[] arr)
        {
            int i, j,k;
            int temp;
            int min;
            for (i = 0; i < arr.Length; ++i)
            {
                min = arr[i];
                k = i;
                for (j = i+1; j < arr.Length; ++j)
                {

                    if (arr[j] < min)
                    {

                        min = arr[j];
                        k = j;

                    }
                }

                temp = arr[k];
                arr[k] = arr[i];
                arr[i] = temp;
                min = arr[i];
                k = i;

            }
        }

        //3.MergeSort
        //Mergesort Recursion
        static void mergesort(int[] arr)
        {
            if (arr.Length == 1)
                return;
            int[] temp = new int[arr.Length / 2];
            int[] temp2 = new int[arr.Length - arr.Length / 2];

            for (int i = 0; i < arr.Length / 2; ++i)
                temp[i] = arr[i];
            for (int i = 0; i < arr.Length - arr.Length / 2; ++i)
                temp2[i] = arr[i + arr.Length / 2];

            mergesort(temp);

            mergesort(temp2);
            merge(temp, temp2, arr);



        }
        //MergeSort Iterator
        static void mergesort2(int[] arr, int[] arr2)
        {
            int i, j, k;
            for (i = 1; i < arr.Length; i = i * 2)
            {
                for (j = 0; j < arr.Length; j = j + 2 * i)
                {

                    merge2(arr, j, Math.Min(j + i, arr.Length), Math.Min(j + 2 * i, arr.Length), arr2);

                }

                for (k = 0; k < arr.Length; ++k)
                    arr[k] = arr2[k];

            }

        }

        static void merge2(int[] arr1, int left, int right, int end, int[] arr2)
        {
            int i = left;
            int j = right;
            int k = left;

            while (j < end && i < right)
            {
                if (arr1[i] <= arr1[j])
                {
                    arr2[k++] = arr1[i++];
                }
                else
                    arr2[k++] = arr1[j++];

            }

            if (j >= end)
            {
                while (i < right)
                    arr2[k++] = arr1[i++];
            }
            else if (i >= right)
            {
                while (j < end)
                    arr2[k++] = arr1[j++];
            }


        }




    }
}
