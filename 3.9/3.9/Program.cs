using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9
{
    class Program
    {
        static void Main(string[] args)
        { /*
            int[] arr = new int[] { 80, 74, 81, 90, 34, 84, 76, 95, 45, 66, 74, 82, 76, 57, 51, 88, 73, 98, 51, 60 };
            
            reverse(arr);

            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            

            
            float a=4.0f, b=5.0f;
            float c;
            Console.Write(Plus(a, b)+"\n");

            */
            char A='A', B='B', C='C';
            
          
            Hanoi(A, B, C, 3);

        

          

        }
        
        static void Hanoi(char A, char B, char C, int n)
        {
            if (n <= 0)
                return;
            Hanoi(A, C, B, n - 1);
            Console.WriteLine("Move disk {0} from "+A+" to"+C,n);
            Hanoi(B,A,C, n - 1);

        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static long Plus(long a, long b)
        {
            return a + b;
        }
        static float Plus(float a, float b)
        {
            return a + b;
        }
        static double Plus(double a, double b)
        {
            return a + b;
        }
        

        static int fibo(int n)
        {
            if (n <= 2)
                return 1;
            else
                return fibo(n - 1) + fibo(n - 2);

                     

        }

       static void reverse(int[] arr)
        {
            int i;
            int n = arr.Length-1;
            int temp;

            for (i = 0; i < arr.Length / 2; ++i)
            {
                temp = arr[n];
                arr[n] = arr[i];
                arr[i] = temp;

                n--;
            }

        }







    }
}
