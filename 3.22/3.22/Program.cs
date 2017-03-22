using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap hs = new Heap(9);
            int[] arr = new int[9] { 1,2,3,4,5,6,7,8,9 };
            int[] sortarr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                hs.insert(arr[i]);
            }

            sortarr = hs.heapsort();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(sortarr[i]+" ");
            }


        }
    }

    

    public class Heap
    {
        int[] heap;
        int count = 0;
        public Heap()
        {
            heap = new int[100];
            for (int i = 0; i < heap.Length; i++)
            {
                heap[i] = -1;
            }
        }
        public Heap(int size)
        {
            heap = new int[size+1];
        }

        public void insert(int num)
        {
            int cur = 1;
            int temp;
            if (count == 0)
            { heap[1] = num;
                count++;
            }
            else
            {
                heap[++count] = num;
                cur = count;
                while (cur > 1)
                {
                    if (heap[cur] < heap[cur / 2])
                    {
                        temp = heap[cur];
                        heap[cur] = heap[cur / 2];
                        heap[cur / 2] = temp;

                    }

                    cur = cur / 2;
                }
           }


        }

        public int delete()
        {
            int returnvalue = 0;
            int i=1;
            int temp;
            if (count <= 0)
            {
                Console.WriteLine("HeapEmpty");
            }
            else
            {
                returnvalue = heap[1];
                heap[1] = heap[count--];

                while (i*2 < heap.Length)
                {
                    if (heap[i] > heap[i * 2] &&heap[i] > heap[i * 2 + 1])
                    {
                        if (heap[i * 2] < heap[i * 2 + 1])
                        {
                            temp = heap[i * 2];
                            heap[i * 2] = heap[i];
                            heap[i] = temp;
                            i = i * 2;
                        }
                        else
                        {
                            temp = heap[i * 2 + 1];
                            heap[i * 2 + 1] = heap[i];
                            heap[i] = temp;
                            i = i * 2 + 1;
                        }

                    }
                    else if (heap[i] > heap[i * 2] &&heap[i] < heap[i * 2 + 1])
                    {
                        temp = heap[i * 2];
                        heap[i * 2] = heap[i];
                        heap[i] = temp;
                        i = i * 2;
                    }
                    else if (heap[i] < heap[i * 2] &&  heap[i] > heap[i * 2 + 1])
                    {
                        temp = heap[i * 2 + 1];
                        heap[i * 2 + 1] = heap[i];
                        heap[i] = temp;
                        i = i * 2 + 1;
                    }
                    else
                        break;
                }


            }
            return returnvalue;
        }

        public int[] heapsort()
        {
            int[] sorted = new int[heap.Length];

            for (int i = 0; i < heap.Length-1; i++)
            {
                sorted[i] = delete();
            }

            return sorted;
        }


    }
}
