using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //float a = 5.0f;
            float mid;
            int[] arr = new int[] { 1, 2, 3, 4, 100 };
            int[] q9num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string s = "The Curious Case of Benjamin Button";
            string ss = "marlin names this last egg nemo, a name that coral like";
            string sss = "a good - hearted and optimistic regal blue tang with short-term memory loss";
            char[] arr2 = new char[35];
            for (int i = 0; i < s.Length; ++i)
                arr2[i] = s[i];
            int q, r;
            int[] arr3 = new int[10];
            int[,] rect = new int[3,5] { { 4, 2, 1, 0, 1 }, { 2, 2, 1, 0, 2 }, { 2, 2, 1, 0, 1 } };
            int[,] mine = new int[5, 5] { { 0, 1, 1, 0, 0 }, { 0, 1, 0, 1, 1 }, { 0, 1, 1, 1, 1 }, { 0, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
            int max;


            //q1(980.0f);
            //Console.WriteLine(q3());
            //Console.WriteLine(q4(arr)*100+"%"); 
            //Console.WriteLine(q5(40,80,60));
            //Console.WriteLine(q6(arr2));
            //Console.WriteLine(q7(1));
            //Console.WriteLine(q8(8,29));
            //q9(q9num);
            //q10(3);
            //q11(99, 8, out q,out r);
            //Console.WriteLine("Child: {0} Parent : {1}", q, r);
            //Console.WriteLine(q12(50, 10, 10, 10, 10));
            //Console.WriteLine(q13(100));
            /*
            arr3 = q14(22);
            for(int i=0;i<arr3.Length;++i)
                Console.Write(arr3[i]+" ");
                */


            // Console.WriteLine(q15("Anaa")); 
            //Console.WriteLine(q16_1(q9num,4)); 
            //Console.WriteLine(q16(q9num,0,q9num.Length-1, 3));
            // q17(sss);
            max=q18(mine);

            //q19(rect);
            Console.WriteLine(max);
        }

        static void q1(float a)
        {

            Console.WriteLine("{0} 20% discount :{1}",a,a*0.8);
        }

        static int q2(int a, int b, int c)
        {
            int mid=0;
            if ((a > b && a < c) || (a>c && a<b))
                mid= a;
            else if ((b > a && b < c) || (b<a && b >c))
                mid=b;
            else if ((c > a && c < b) || (c<a && c>b))
                mid= c;

            return mid;

        }
        static int q3()
        {
            int sum = 0;
          
            int i;

            for (i = 0; i < 16; ++i)
            {
                if (i % 3 == 0)
                    sum += i;
                else if (i % 5 == 0)
                    sum += i;

            }

            return sum;
         }
        static float q4(int[] arr)
        {
            int sum=0;
            float avg,count=0;
            int i;

            for (i = 0; i < arr.Length; ++i)
            {
                sum += arr[i];
            }
            avg = sum / arr.Length;
            
            for (i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < avg)
                    count++;
            }

            avg = count / arr.Length;

            return avg;
        }

        static float q5(int a,int b,int c)
        {
            int max=a;
            float i, j, k;
            float avg;
            if (max < b)
                max = b;
            if (max < c)
                max = c;

            i = (float)a/max  * 100;
            j = (float)b/max  * 100;
            k = (float)c/max  * 100;

            avg = (i + j + k) / 3;
            return avg;
        }

        static int q6(char[] arr)
        {
            int i,count=0;
            for (i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == ' ')
                    count++;
            }

            return count+1;
        }

        static char q7(int num)
        {
            char c;

            if (num >= 90)
                c = 'A';
            else if (num >= 80)
                c = 'B';
            else if (num >= 70)
                c = 'C';
            else if (num >= 60)
                c = 'D';
            else
                c = 'F';

            return c;


        }

        static string q8(int x, int y)
        {
            int sum = 0;
            int i;
            string day;

            for (i=1; i < x; ++i)
            {
                if (i == 2)
                    sum += 28;
                else if (i <= 7)
                {
                    if (i % 2 == 1)
                        sum += 31;
                    else
                        sum += 30;
                }
                else if (i >= 8)
                {
                    if (i % 2 == 1)
                        sum += 30;
                    else
                        sum += 31;
                }
            }

            sum += y;

            if (sum % 7 == 1)
                day = "Monday";
            else if (sum % 7 == 2)
                day = "Tuesday";
            else if (sum % 7 == 3)
                day = "Wednesday";
            else if (sum % 7 == 4)
                day = "Thursday";
            else if (sum % 7 == 5)
                day = "Friday";
            else if (sum % 7 == 6)
                day = "Saturday";
            else
                day = "Sunday";

            return day;


        }

        static void q9(int[] arr)
        {
            int i;
            int count = 0;
            for (i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i]+" ");
                count++;
                if (count % 10 == 0)
                    Console.WriteLine();

            }
            Console.WriteLine();
        }

        static void q10(int num)
        {
            int i;
            for (i = 1; i < 10; ++i)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);


            }
        }
        static void q11(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static float q12(int a, int b, int c, int d, int e)
        {
            float avg;
            if (a < 40)
                a = 40;
            if (b < 40)
                b = 40;
            if (c < 40)
                c = 40;
            if (d < 40)
                d = 40;
            if (e < 40)
                e = 40;

            avg = (a + b + c + d + e) / 5;
            return avg;

        }

        static int q13(int n)
        {
            int count=0;

            while (n > 0)
            {
                if (n - 5 >= 0)
                {
                    count++;
                    n -= 5;
                }
                else {
                    count++;
                    n -= 3;
                }
            }
            return count;
        }

        static int[] q14(int n)
        {
            int[] arr = new int[10];
            int i;
            int quotient;
            for (i = 1; i <= n; ++i)
            {

                if (i < 10)
                    arr[i] += 1;
                else
                {
                    quotient = i / 10;
                    arr[quotient] += 1;
                    arr[i % 10] += 1;
                }
                
            }

            return arr;
        }

        static bool q15(string s)
        {
            int i;
            bool b=true;
            int n = s.Length-1;
           s= s.ToLower();
            for (i = 0; i < s.Length/2; ++i)
            {
                if (s[i] != s[n])
                    b = false;
                else
                    n--;
            }

                    return b;
        }

        static int q16_1(int[] arr, int k)
        {
            int i,j;
            int min = 999;
            int key=0;
            for (i = 0; i < k; ++i)
            {
                for (j = 0; j < arr.Length; ++j)
                {
                    if (arr[j] < min)
                    {
                        min = arr[i];
                        key = j;
                    }
                }
                if (key + 1 == k)
                    break;
                arr[key] = 999;
                min = 999;
            }
            return arr[key];
        }

        static int q16(int[] arr,int start,int end, int k)
        {
            int pivot = (start + end) / 2;
            int left = start;
            int right = end;

            int temp;
            temp = arr[pivot];
            arr[pivot] = arr[start];
            arr[start] = temp;
            

            while (left <= right)
            {
                if (arr[start] >= arr[left])
                    left++;
                else if (arr[start] < arr[left])
                {
                    if (arr[start] >= arr[right])
                    {
                        temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;

                    }
                    else
                        right--; 
                }
            }

            temp = arr[left - 1];
            arr[left - 1] = arr[start];
            arr[start] = temp;

            pivot = left - 1;
            if (pivot == k-1)
                return arr[pivot];
            else if (k > pivot)
            {
                return q16(arr, pivot + 1, end, k);
            }
            else
                return q16(arr, start, pivot - 1, k);
            
        }

        static void q17(string s)
        {
            int i;
            bool b=false;
            for (i = 0; i < s.Length; ++i)
            {
                if (s[i] == 'n' && s[i + 1] == 'e' && s[i + 2] == 'm' && s[i + 3] == 'o')
                {
                    Console.WriteLine("found");
                    b = true;
                }
                
            }
            if(b !=true)
                Console.WriteLine("missing");
        }
        
        static int q18(int[,] arr)
        {
            int i, j,k,l;
            int row, col;
            int left=0;
            int dia = 0;
            int sucecc = 1;
            for (i = 0; i < arr.GetLength(0); ++i)
            {
                for (j = 0; j < arr.GetLength(1); ++j)
                {
                    left = 0;
                   
                    if (arr[i,j] == 1)
                    {
                        row = i;
                        col = j;

                        if (leftdown(arr, row, col))
                        {
                            row++;
                            col--;
                            left++;
                            while (leftdown(arr, row, col))
                            {
                                row++;
                                col--;
                                left++;
                            }

                            
                            
                            for (k = left; k > 0; --k)
                            {
                                for (l = 0; l <= k; ++l)
                                {
                                    if (col + 1 >= arr.GetLength(1) || row + 1 >= arr.GetLength(0))
                                        break;
                                    if (rightdown(arr, row, col) == false)
                                    {
                                        sucecc = 0;
                                        break;
                                    }
                                   

                                     row++;
                                    col++;
                                }
                                if (sucecc == 0)
                                    break;
                                
                                for (l = 0; l <= k; ++l)
                                {
                                    if (col + 1 >= arr.GetLength(1) || row - 1 < 0)
                                        break;
                                    if (rightup(arr, row, col) == false)
                                    {
                                        sucecc = 0;
                                        break;
                                    }
                                  
                                    col++;
                                    row--;
                                }
                                if (sucecc == 0)
                                    break;
                                for (l = 0; l <= k; ++l)
                                {
                                    if (col - 1 < 0 || row - 1 < 0)
                                        break;
                                    if (leftup(arr, row, col) == false)
                                    {
                                        sucecc = 0;
                                        break;
                                    }
                                   

                                    row--;
                                    col--;
                                }
                                if (sucecc == 0)
                                    break;
                                else
                                {
                                    if(left+1>dia)
                                        dia = left + 1;
                                }


                            }
                        }

                    }

                }
            }
            return dia;
        }

        static bool leftdown(int[,] arr,int row,int col)
        {
            bool b=false;
            if (col-1 < 0 || row+1 >= arr.GetLength(0))
                return b; 

            if (arr[row + 1, col - 1] == 1)
                b = true;

            return b;
        }

        static bool rightdown(int[,] arr, int row, int col)
        {
            bool b = false;
            if (col+1 >= arr.GetLength(1) || row +1>= arr.GetLength(0))
                return b;

            if (arr[row + 1, col + 1] == 1)
                b = true;

            return b;

        }

        static bool rightup(int[,] arr, int row, int col)
        {
            bool b = false;
            if (col+1 >= arr.GetLength(1) || row-1 < 0)
                return b;
            if (arr[row - 1, col + 1] == 1)
                b = true;
            return b;
        }
        static bool leftup(int[,] arr, int row, int col)
        {
            bool b = false;
            if (col - 1 <0 || row - 1 < 0)
                return b;
            if (arr[row - 1, col -1] == 1)
                b = true;
            return b;
        }


        /*
                        row = i;
                        col = j;
                        while(row<=arr.Length && col>=0)
                         {
                            if (arr[row + 1][col - 1] == 1)
                                left++;
                            else
                                break;
                            row -= 1;
                            col -= 1;

                         }
                        if (left > 0)
                        {
                            while (left > 0 && row<=arr.Length && col<=arr[i].Length)
                            {
                                if(arr[row+1][col+1]==1)
                                    
                            }
                        }
                       */

        static void q19(int[,] arr)
        {
            int i;
            int j;
            int k;
            int num;
            int dept;
            int max=0;
          
            for (i = 0; i < arr.GetLength(0)-1; ++i)
            {
                for (j = 0; j < arr.GetLength(1); ++j)
                {
                    for (k = j+1; k < arr.GetLength(1); ++k)
                    {
                        if (arr[i,j] == arr[i,k])
                        {
                            
                            dept = k - j;
                            if (dept < arr.GetLength(0) && k<arr.GetLength(1))
                            { if (arr[i, j] == arr[dept, j] && arr[i, j] == arr[dept, k])
                                {
                                    if (max < dept + 1)
                                        max = dept + 1;
                                }
                            }

                        }
                    }
                }
            }

            Console.WriteLine(max*max);
        }
    }
}
