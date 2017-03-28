using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._27
{
    class Program
    {
        static void Main(string[] args)
        {
            Bst MyBst = new Bst();

            MyBst.insert(15);
            MyBst.insert(13);
            MyBst.insert(19);
            MyBst.insert(9);
            MyBst.insert(14);
            
            MyBst.insert(17);
            MyBst.insert(21);
            MyBst.insert(8);
            MyBst.insert(11);
            MyBst.insert(16);
            MyBst.insert(18);
            MyBst.insert(20);
            MyBst.insert(23);

            MyBst.delete(19);
            MyBst.delete(18);
            MyBst.delete(17);
            MyBst.delete(16);
            MyBst.delete(20);
            MyBst.delete(21);
            MyBst.delete(23);

        }


        class BtreeNode
        {
            public int val;
            public BtreeNode left;
            public BtreeNode right;

            public BtreeNode()
            {
                left = null;
                right = null;

            }
        }

        class Bst
        {
            BtreeNode root;

            public Bst()
            {
                root = null;

            }

            public void insert(int num)
            {
                BtreeNode temp = new BtreeNode();
                BtreeNode cur;
                BtreeNode parent;

                temp.val = num;
                temp.left = null;
                temp.right = null;

                if (root == null)
                {
                    root = temp;
                }

                else
                {
                    cur = root;
                    parent = cur;
                    while (cur != null)
                    {
                        parent = cur;
                        if (num < cur.val)
                        {
                           cur = cur.left;

                        }
                        else
                        {
                          
                            cur = cur.right;
                        }

                    }
                    if (num < parent.val)
                        parent.left = temp;
                    else
                        parent.right = temp;
               }
            }

            public void search(int k)
            {
                BtreeNode cur = root;
                while (cur != null)
                {
                    if (cur.val == k)
                    {
                        Console.WriteLine("Find");
                        break;
                    }
                    else if (cur.val > k)
                        cur = cur.left;
                    else
                        cur = cur.right;
                }

                if (cur == null)
                    Console.WriteLine("Not Find");

            }

            public void delete(int k)
            {

                BtreeNode target = root;
                BtreeNode lastnode;
                BtreeNode targetparent=root;
                BtreeNode parentoflastnode;
                if (root == null)
                    Console.WriteLine(" BST is Empty");
                else
                {
                    while (target != null)
                    {
                        if (target.val == k)
                        {
                            break;
                        }
                        else if (target.val > k)
                        {
                            targetparent = target;
                            target = target.left;

                        }
                        else
                        {
                            targetparent = target;
                            target = target.right;
                        }
                    }

                    if (root == null)
                        Console.WriteLine("Not Exist number");
                    else
                    {
                        lastnode = target;
                        if (lastnode.left != null)
                        {
                            parentoflastnode = lastnode;
                            lastnode = lastnode.left;
                            while (lastnode.right != null)
                            {
                                parentoflastnode = lastnode;
                                lastnode = lastnode.right;
                            }

                            if (targetparent.right.val == target.val)
                            {
                                targetparent.right = lastnode;
                            }
                            else
                                targetparent.left = lastnode;

                            if (parentoflastnode.val != target.val)
                            {
                                parentoflastnode.right = null;
                                lastnode.left = target.left;
                            }
                            lastnode.right = target.right;


                            /* if(parentoflastnode.val != target.val)
                                 lastnode.left = parentoflastnode;*/
                            target.left = null;
                            target.right = null;


                            if (root.val == k)
                                root = lastnode;

                        }
                        else if (lastnode.left == null && lastnode.right != null)
                        {
                            parentoflastnode = lastnode;
                            lastnode = lastnode.right;
                            while (lastnode.left != null)
                            {
                                parentoflastnode = lastnode;
                                lastnode = lastnode.left;
                            }

                            if (targetparent.right.val == target.val)
                            {
                                targetparent.right = lastnode;
                            }
                            else
                                targetparent.left = lastnode;

                            if (parentoflastnode.val != target.val)
                            {
                                parentoflastnode.left = null;
                                lastnode.right = target.right;
                            }

                            target.left = null;
                            target.right = null;

                        }
                        else if (lastnode.left == null && lastnode.right == null)
                        {
                            if (targetparent.right.val == target.val)
                            {
                                targetparent.right = null;
                            }
                            else
                                targetparent.left = null;
                        }
                    }

                }

            }

        }


    }

   
}
