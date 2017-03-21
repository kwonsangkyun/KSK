using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._21
{
    class Program
    {
        static void Main(string[] args)
        {

            heap mh = new heap();
            
           
                mh.insert(3);
            mh.insert(5);
            mh.insert(6);
            mh.insert(7);
            mh.insert(20);
            mh.insert(8);
            mh.insert(2);
            mh.insert(9);


            for (int i = 0; i < 7; i++)
            {
                Console.Write(mh.delete()+" ");
            }
            
            
        }
    }

    class heap
    {
        class TreeNode
        {
            public int val;
            public TreeNode leftchild;
            public TreeNode rightchild;
            public TreeNode parent;
        }

        TreeNode root = null;
        TreeNode tail = null;

        public int delete()
        {
            TreeNode cur = null;
            TreeNode p;
            int temp=0;
            if (root == null)
            {
                Console.WriteLine("Empty Heap");
            }
            else
            {
                if (tail.rightchild != null)
                {
                    cur = tail.rightchild;
                    tail.rightchild = null;

                }
                else if(tail.leftchild !=null)
                {
                    cur = tail.leftchild;
                    tail.leftchild = null;
                }
                else
                {
                    

                    while (tail != null && tail != root)
                    {
                        if (tail == tail.parent.rightchild) // 부모의 right child 일때까지
                            break;
                        else
                            tail = tail.parent;
                    }

                    if (tail == root)
                    {
                        while (tail.rightchild != null)
                            tail = tail.rightchild;
                    }
                    else
                    {
                        tail = tail.parent.leftchild; //root 까지온경우 x

                        while (tail.rightchild != null)
                            tail = tail.rightchild;
                    }

                    tail = tail.parent;
                    cur = tail.rightchild;
                    tail.rightchild = null;
                }
                cur.parent = null;
                temp = root.val;
                root.val = cur.val;
                if (tail.leftchild != null)
                    makeheap2(tail.leftchild);
                else
                    makeheap2(tail);
            }
            return temp;
        }

        public void insert(int num)
        {
            TreeNode temp = new TreeNode();

            TreeNode cur = null ;
            temp.val = num;
            temp.leftchild = null;
            temp.rightchild = null;
            temp.parent = null;

            if (root == null)
            {

                root = temp;
                tail = temp;
            }
            else
            {
                if (tail.leftchild == null)
                {
                    tail.leftchild = temp;
                    temp.parent = tail;
                   
                    cur = temp;
                }
                else
                {
                   
                    tail.rightchild = temp;
                    temp.parent = tail;
                    cur = temp;
                    while (tail != null && tail != root)
                    {
                        if (tail == tail.parent.leftchild) // 부모의 left child 일때까지
                            break;
                        else
                            tail = tail.parent;
                    }
                    if (tail == root)
                    {
                        while (tail.leftchild != null)
                            tail = tail.leftchild;
                    }
                    else
                    {
                        tail = tail.parent.rightchild; //root 까지온경우 x

                        while (tail.leftchild != null)
                            tail = tail.leftchild;
                    }
                    
                }

                makeheap(cur);
            }
            
        }
            void makeheap(TreeNode i)
            {
                int temp;
                while (i.parent != null)
                {
                    if (i.val > i.parent.val)
                    {
                        temp = i.val;
                        i.val = i.parent.val;
                        i.parent.val = temp;
                    }
                    i = i.parent;
                }

            }
        void makeheap2(TreeNode i)
        {
            int temp;
            TreeNode j;
            while (i.parent != null)
            {
                j = i.parent;
                while (j != null)
                {
                    if (i.val > j.val)
                    {
                        temp = i.val;
                        i.val = j.val;
                        j.val = temp;
                    }
                    j = j.parent;
                }

                i = i.parent;

            }

            j = root;
            while (j!= null)
            {
                if (j.leftchild !=null &&j.val < j.leftchild.val)
                {
                    temp = j.val;
                    j.val = j.leftchild.val;
                    j.leftchild.val = temp;
                    j = j.leftchild;
                    
                  
                
                }
                else if (j.rightchild !=null &&j.val < j.rightchild.val)
                {
                    temp = j.val;
                    j.val = j.rightchild.val;
                    j.rightchild.val = temp;
                    j = j.rightchild;
                    
                 
                }
                else
                    break;
            }

           
        }
        

        
    }
}