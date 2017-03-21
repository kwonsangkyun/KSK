using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._15
{

    class My_Queue
    {
        int[] arr;
        int front = 0;
        int rear = 0;

        public My_Queue(int size)
        {
            arr = new int[size];

        }
        public void enqueue(int num)
        {
            rear = (rear) % arr.Length;

            if ( (rear+1)%arr.Length != front)
                arr[rear++] = num;
            else
                Console.WriteLine("full");
          

        }

        public int dequeue()
        {
            front = front % arr.Length;
            if (front!=rear)
                return arr[front++];
            else
            {
                Console.WriteLine("Empty");
                return -1;
            }
        }


    }

   
    class Program
    {
        static void Main(string[] args)
        {
            
            My_Queue q = new My_Queue(5);
            Random rand = new Random();
            int[] arr = new int[11];
            Queue<int> mq = new Queue<int>();
            
            int i;              
            int count = 0;
            int sum = 0;
           

            for (i = 0; i < arr.Length; ++i)
            {
                arr[i] = rand.Next(0, 9);
            }
            i = 0;

            while (i < arr.Length)
            {
                if (sum < 9)
                {
                    sum += arr[i];
                    mq.Enqueue(arr[i++]);
                   
                }
                else if (sum > 9)
                {
                    sum -= mq.Dequeue();
                }
                else
                {
                   count++;
                   sum -= mq.Dequeue();
                }


            }
            if (sum == 9)
            {
                count++;
            }

            Console.WriteLine(count);

        }
        static void check(string s)
        {

            Stack < char > st = new Stack<char>();
            bool b=true;
            

           

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(' || s[i] == '{' ||s[i]=='[')
                {
                    st.Push(s[i]);
                }

                if (s[i] == ')')
                {
                    if (st.Count <= 0)
                    {
                        b = false;
                        break;
                    }
                    if (st.Pop() != '(')
                    {
                        b = false;
                        break;
                    }
                }

                else if (s[i] == '}')
                {
                    if (st.Count <= 0)
                    {
                        b = false;
                        break;
                    }
                    if (st.Pop() != '{')
                    {
                        b = false;
                        break;
                    }

                }

                else if (s[i] == ']')
                {
                    if (st.Count <= 0)
                    {
                        b = false;
                        break;
                    }
                    if (st.Pop() != '[')
                    {
                        b = false;
                        break;
                    }

                }


            }

            Console.WriteLine(b);

            



        }
    }
}
