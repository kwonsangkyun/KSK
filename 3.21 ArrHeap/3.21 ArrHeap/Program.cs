using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._21_ArrHeap
{
    class Program
    {
        public static int[] heap = new int[17];
        public static int i = 1;
        public static int count = 1;

        static void Main(string[] args)
        {
            

            for (int j = 0; j<17; j++)
            {
                heap[j] = -1;
            }
            insert(3);
            
            insert(5);
            insert(6);
            insert(7);
            insert(20);
            insert(8);
            insert(2);
            insert(9);

            for (int j = 0; j <count ; j++)
            {
                Console.WriteLine(delete());
            }
            
            


        }

        static void insert(int num)
        {
            
            if (heap[1] == -1)
            {
                heap[1] = num;
                i++;
            }
            else
            {
                heap[i++] = num;
                int j = i - 1;
                int temp;
                while (j > 1)
                {
                    if (heap[j] > heap[j / 2])
                    {
                        temp = heap[j];
                        heap[j] = heap[j / 2];
                        heap[j / 2] = temp;

                    }
                    j = j / 2;
                }
            }
            count++;
        }

        static int delete()
        {
            int returnvalue;
            int temp;
            returnvalue = heap[1];
            if (returnvalue == -1)
                Console.WriteLine("Empty");

            heap[1] = heap[i--];

            for (int j = 1; j < heap.Length/2;)
            {
                if (heap[j] < heap[j * 2] && heap[j] < heap[j * 2 + 1])
                {
                    if (heap[j * 2] > heap[j * 2 + 1])
                    {
                        temp = heap[j * 2];
                        heap[j * 2] = heap[j];
                        heap[j] = temp;
                        j = j * 2;
                    }
                    else
                    {
                        temp = heap[j * 2 + 1];
                        heap[j * 2 + 1] = heap[j];
                        heap[j] = temp;
                        j = j * 2 + 1;
                    }
                }
                else if (heap[j] < heap[j * 2] && heap[j] > heap[j * 2 + 1])
                {
                    temp = heap[j * 2];
                    heap[j * 2] = heap[j];
                    heap[j] = temp;
                    j = j * 2;
                }
                else if (heap[j] > heap[j * 2] && heap[j] < heap[j * 2 + 1])
                {
                    temp = heap[j * 2 + 1];
                    heap[j * 2 + 1] = heap[j];
                    heap[j] = temp;
                    j = j * 2 + 1;
                }
                else
                    break;

            }


            return returnvalue;

        }

       
    }
}
