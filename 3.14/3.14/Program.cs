using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._14
{
    class Stack_t
    {
        int top = 0;
        int[] arr;

        public Stack_t(int size)
        {
            arr= new int[size];
        }

        public void push(int a)
        {
            if (top < arr.Length)
                arr[top++] = a;
            else
                Console.WriteLine("Stack OverFlow");

        }

        public int pop()
        {
            if (top > 0)
                return arr[--top];
            else
                return -1;
            
        }
        


    }



    class Program
    {
        static void Main(string[] args)
        {
            Stack_t mystack = new Stack_t(5);


            string s=Console.ReadLine();

            Calculator(s);


           
        }

        static void Calculator(string s)
        {
            
          
            int x, y;
            Stack<int>  numstack= new Stack<int>();
            //Stack<char> tokenstack = new Stack<char>();
            int count = 0;
            int i;

            for (i = 0; i < s.Length; ++i)
            {
                if (s[i] != '*' && s[i] != '+' && s[i] != '/' && s[i] != '-')
          
                {
                    numstack.Push(Convert.ToInt32(s[i]-48));
                }
                else if (s[i] == '*')
                {
                    x = numstack.Pop();
                    y = s[i + 1]-48;
                    numstack.Push(x * y);
                    i++;
                }
                else if (s[i] == '/')
                {
                    x = numstack.Pop();
                    y = s[i + 1] - 48;
                    numstack.Push(x / y);
                    i++;
                }
                else
                {
                    if (s[i] == '-')
                    {
                        numstack.Push((s[i + 1] - 48) * -1);
                    }
                    count++;
                    //tokenstack.Push(s[i]);
                }

            }

            while (count > 0)
            {
                
                    
                    x = numstack.Pop();
                    y = numstack.Pop();
                    numstack.Push(x + y);

                count--;
            }

            Console.WriteLine( numstack.Pop());

            

        }

        
        static string IntToString(int n)
        {
            
            string s=null;
            char c;
            int i=1;
            int count=0;
            int num = n;
            int temp;

            if (num == 0)
            {
                
                return "0";
            }
            if (num < 0)
            {
                num = num * -1;
            }

            while (num > 0)
            {
                num = num / 10;

                i*=10;
                count++;
            }
        

            i /= 10;


            num = n;
            if (num < 0)
            {
                num = num * -1;
            }

            if (n >= 0)
            {
                for (int j=0; j < count; ++j)
                {
                    temp=num / i+48;
                    c = (char)temp;
                    s = s + c;
                    num = num % i;
                    i /= 10;
                }
            
            }
            else
            {
                s = s + '-';
                for (int j = 0; j < count; ++j)
                {
                    temp = num / i+48;
                    c = (char)temp;
                    s = s + c;
                    num = num % i;
                    i /= 10;

                }
            }

            return s;

        }
    }
}


