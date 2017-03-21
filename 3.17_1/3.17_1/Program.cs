using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3._17_1
{
    class Program
    {

        class Node
        {
            public int val;
            public Node next;
        }
        Node head = null;
        Node tail = null;
        int count = 0;

        static void Main(string[] args)
        {

            Program pg = new Program();

            for (int i = 0; i < 10; ++i)
                pg.insert(i);

            pg.SerchK2(2);
            //pg.SerchK(2);
            pg.insert(6);
        }

        public void SerchK(int k)
        {
            Node t = head;
            for (int i = 0; i < count - k; ++i)
                t = t.next;

            Console.WriteLine(t.val);
        }

        public void SerchK2(int k)
        {
            Node prev = null, cur, next;
            cur = head;

            while (cur != null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;

            }

            head = prev;
            cur = head;
            for (int i = 0; i < k - 1; ++i)
            {
                cur = cur.next;
            }

            Console.WriteLine(cur.val);

        }

        public void insert(int num)
        {
            Node tmp = new Node();
            tmp.val = num;
            tmp.next = null;
            if (head == null)
            {
                head = tmp;
                tail = tmp;
            }
            else
            {
                tail.next = tmp;
                tail = tmp;
            }

            count++;
        }
    }
}