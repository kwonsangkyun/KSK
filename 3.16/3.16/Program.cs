using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._16
{
    class ArrQueue
    {
        int[] numarr;
        int[] indexarr;
        int rear = 0;
        int front = 0;

        public ArrQueue(int size)
        {
            numarr = new int[size];
            indexarr = new int[size];
            

            for (int i = 0; i < indexarr.Length; ++i)
            {
                indexarr[i] = -1;
            }
        }

        public void Enqueue(int num)
        {
            if (rear < numarr.Length)
            {
                numarr[rear] = num;
                if(rear+1<numarr.Length)
                    indexarr[rear] = ++rear;
            }
            else
                Console.WriteLine("FULL");
        }

        public int Dequeue()
        {
            if (front < rear)
            {
                front = indexarr[front++];
                return numarr[front];
                
            }
            else
            {
                Console.WriteLine("EMPTY");
                return -1;
            }
        }

       
    }
    class ArrStack
    {
        int[] numarr;
        int[] indexarr;
        int top = 0;
        public ArrStack(int size)
        {
            numarr = new int[size];
            indexarr = new int[size];

            for (int i = 0; i < indexarr.Length; ++i)
                indexarr[i] = -1;
        }

        public void push(int num)
        {
            if (top < numarr.Length)
            {
                numarr[top] = num;
                if (top + 1 >= numarr.Length)
                    indexarr[top] = -1;
                else
                    indexarr[top] = ++top;


            }
            else
                Console.WriteLine("FULL");    
            
        }

        public int pop()
        {
            if (top > 0)
            {
                indexarr[top - 1] = -1;
                return numarr[top--];
            }
            else
            {
                Console.WriteLine("Empty");
                return -1;
            }
        }

    }

    class LinkedQueue
    {
        public class Node
        {
            public int val;
            public Node next;
        }

        Node head = null;
        Node rear = null;

        public void EnQueue(int num)
        {
            Node tmp = new Node();
            tmp.val = num;
            tmp.next = null;

            if (head == null)
            {
                head = tmp;
                rear = head;
            }

            rear.next = tmp;
            rear = tmp;
        }

        public int DeQueue()
        {
            int ReturnValue;

            if (head == null)
            {
                return -1;
            }

            if (head.next == null)
            {
                ReturnValue = head.val;
                head = null;
                rear = null;
                return ReturnValue;

            }

            ReturnValue = head.val;
            head = head.next;
            return ReturnValue;




        }


    }

    class DoubleLinkedStack
    {
        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
        }
        Node head = null;
        Node top = null;

        public void push(int num)
        {
            Node tmp = new Node();
            tmp.val = num;
            tmp.next = null;
            tmp.prev = null;

            if (head == null)
            {
                head = tmp;
                top = tmp;

            }
            else
            {
                top.next = tmp;
                tmp.prev = top;
                top = tmp;
            }
        }

        public int pop()
        {
            int Rv;
            if (head == null)
            {
                Console.WriteLine("Stack Empty");
                return -1;
            }

            if (top.prev == null)
            {
                Rv = top.val;
                head = null;
                top = null;
                return Rv;
            }

            Rv = top.val;
            top = top.prev;

            return Rv;

        }

    }
    class LinkedStack
    {


        public class Node
        {
            public int val;
            public Node next;
        }


        Node head = null;

        Node top = null;

        public void push(int num)
        {
            Node tmp = new Node();

            tmp.val = num;
            tmp.next = null;
            if (head == null)
            {
                head = tmp;
                top = head;
            }
            else
            {
                top.next = tmp;
                top = tmp;
            }
        }
        public int pop()
        {
            Node cur = head;
            int returnvalue;
            if (head == null)
                return -1;

            if (cur.next == null)
            {
                returnvalue = cur.val;
                head = null;
                top = null;
                return returnvalue;
            }

            while (cur.next != top)
            {
                cur = cur.next;
            }

            returnvalue = top.val;
            top = cur;
            top.next = null;

            return returnvalue;

        }


    }

    class Program
    {
        class Node
        {
            public int val;
            public Node next;
        }
        Node head = null;
        
        static void Main(string[] args)
        {
            LinkedStack st = new LinkedStack();
            LinkedQueue q = new LinkedQueue();
            Random rand = new Random();
            Program pg = new Program();
            DoubleLinkedStack dst = new DoubleLinkedStack();
            ArrStack at = new ArrStack(10);
            ArrQueue aq = new ArrQueue(10);
            for (int i = 0; i < 10; ++i)
            {
                st.push(i);
                dst.push(i);
                q.EnQueue(i);
                at.push(i);
                aq.Enqueue(i);
            }
           
            for (int i = 0; i < 15; ++i)
            {
                // Console.WriteLine(st.pop());
                //Console.WriteLine(q.DeQueue());
                // pg.Sort(rand.Next(1, 10));
                Console.Write(aq.Dequeue()+" ");

            }
            Console.WriteLine();
            //Console.WriteLine(q.DeQueue());

        }

        public void Sort(int num)
        {
            Node tmp = new Node();
            Node cur = head;
            tmp.val = num;
            tmp.next = null;

            if (head == null)
            {
                head = tmp;
            }

            if (tmp.val < head.val)
            {
                tmp.next = head;
                head = tmp;
            }
            else
            {
                while (cur != null)
                {
                    if (cur.next == null)
                    {
                        cur.next = tmp;
                        break;
                    }

                    if (cur.next.val > tmp.val)
                    {
                        tmp.next = cur.next;
                        cur.next = tmp;
                        break;
                    }
                   
                    cur = cur.next;
                }
            }

            Console.WriteLine("input num {0}", num);
            cur = head;
            while (cur != null)
            {
                Console.Write(cur.val + " ");
                cur = cur.next;
            }
            Console.WriteLine();


        }

    }
}
    

