using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVl_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Avltree avl = new Avltree();
           
            avl.insert( 1);
            avl.insert(2);
            avl.insert(3);
            /*
            avl.insert(4);
            avl.insert( 6);
            avl.insert(17);
            avl.insert(7);
            avl.insert(8);
            avl.insert(9);
            avl.insert(1);
            avl.delete(5);
            avl.delete(10);
            */
            Random rand = new Random();

            for (int i = 1000; i > 0; i--)
            {
                avl.insert(rand.Next());
            }
            avl.delete(489);
            avl.TravelsByIn();
            //avl.insert(ref avl.root,1);
            // avl.delete(5);
        }

        class AVLNode
        {
            public int val;
            public AVLNode left;
            public AVLNode right;
            public AVLNode parent;

            public AVLNode()
            {
                left = null;
                right = null;
                parent = null;

            }

        }

        class Avltree
        {
            AVLNode root;
            public Avltree()
            {
                root = null;
            }


            AVLNode rebalance(AVLNode node)
            {
                int bal_num = get_balanced_num(node);
                if (bal_num > 1)
                {
                    if (get_balanced_num(node.left) > 0)
                        node = rotate_LL(node);
                    else
                        node = rotate_LR(node);
                }
                else if (bal_num < -1)
                {
                    if (get_balanced_num(node.right) < 0)
                        node = rotate_RR(node);
                    else
                        node = rotate_RL(node);


                }
                return node;
            }

            AVLNode rotate_RR(AVLNode parent)
            {
                AVLNode child = parent.right;
                parent.right = child.left;
                if (child.left != null)
                    child.left.parent = parent;
                child.left = parent;
                child.parent = parent.parent;
                if (parent != root)
                {
                    if (parent.parent.right == parent)
                        parent.parent.right = child;
                    else
                        parent.parent.left = child;
                }
                else if (parent == root)
                    root = child;
                parent.parent = child;
                return child;

            }
            AVLNode rotate_LL(AVLNode parent)
            {
                AVLNode child = parent.left;
                parent.left = child.right;
                if(child.right!=null)
                    child.right.parent = parent;
                child.right = parent;
                child.parent = parent.parent;
                if (parent != root)
                {
                    if (parent.parent.right == parent)
                        parent.parent.right = child;
                    else
                        parent.parent.left = child;
                }
                else if (parent == root)
                    root = child;
                parent.parent = child;
                return child;
            }
            AVLNode rotate_LR(AVLNode parent)
            {
                AVLNode child = parent.left;
                parent.left = rotate_RR(child);
                return rotate_LL(parent);
            }
            AVLNode rotate_RL(AVLNode parent)
            {
                AVLNode child = parent.right;
                parent.right = rotate_LL(child);
                return rotate_RR(parent);
            }
            int get_height(AVLNode node)
            {
                int height = 0;

                if (node != null)
                    height = 1 + Math.Max(get_height(node.left), get_height(node.right));
                return height;
            }
            int get_balanced_num(AVLNode node)
            {
                if (node == null)
                    return 0;
                else
                    return get_height(node.left) - get_height(node.right);
            }
            public void insert(int num)
            {
                AVLNode temp = new AVLNode();
                AVLNode cur = root;
                AVLNode parent = root;

                temp.val = num;
                if (root == null)
                {
                    root = temp;
                    cur = root;
                }
                else
                {
                    cur = root;

                    while (true)
                    {
                        if (cur.val > num)
                        {
                            if (cur.left == null)
                            {
                                cur.left = temp;
                                cur.left.parent = cur;
                                break;
                            }
                            else
                                cur = cur.left;
                        }
                        else if (cur.val <= num)
                        {
                            if (cur.right == null)
                            {
                                cur.right = temp;
                                cur.right.parent = cur;
                                break;
                            }
                            else
                                cur = cur.right;

                        }
                    }
                }
                
                while (cur!= null)
                {
                    cur = rebalance(cur);
                    if (cur.parent != null)
                        cur = cur.parent;
                    else
                        break;
                }
               
             

            }
            public void delete(int num)
            {
                AVLNode parent;
                AVLNode cur;
                AVLNode temp;
                AVLNode Succ, Succ_parent;
                parent = null;
                cur = root;

                while (cur != null && cur.val != num)
                {
                    parent = cur;
                    if (num < cur.val)
                        cur = cur.left;
                    else
                        cur = cur.right;
                }

                if (cur == null)
                    Console.WriteLine("not exist");
                else
                {
                    if (cur.left == null && cur.right == null)
                    {
                        if (parent != null)
                        {
                            if (parent.left == cur)
                                parent.left = null;
                            else
                                parent.right = null;
                        }
                        else
                            root = null;
                    }
                    else if ((cur.left == null && cur.right != null) || (cur.left != null && cur.right == null))
                    {
                        if (cur.left == null)
                            temp = cur.right;
                        else
                            temp = cur.left;

                        if (parent != null)
                        {
                            if (parent.left.val == cur.val)
                                parent.left = temp;
                            else
                                parent.right = temp;
                        }
                        else
                            root = temp;
                    }
                    else
                    {
                        Succ_parent = cur;
                        Succ = cur.right;
                        while (Succ.left != null)
                        {
                            Succ_parent = Succ;
                            Succ = Succ.left;
                        }

                        if (Succ_parent.left.val == Succ.val)
                            Succ_parent.left = Succ.right;
                        else
                            Succ_parent.right = Succ.right;

                        cur.val = Succ.val;

                    }

                    while (cur.parent != null)
                    {
                        cur = rebalance(cur);
                        cur = cur.parent;
                    }
                }

            }
            void TravelsByIn(AVLNode _root)
            {
                if (_root.left != null)
                    TravelsByIn(_root.left);
                Console.Write(_root.val + " ");
                if (_root.right != null)
                    TravelsByIn(_root.right);

            }



            public void TravelsByIn()
            {
                TravelsByIn(root);
                Console.WriteLine();

            }


        }

    }
}
