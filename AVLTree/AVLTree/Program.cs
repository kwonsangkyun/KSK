using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Avltree avl = new Avltree();

            avl.insert(ref avl.root, 9);
            avl.insert(ref avl.root, 8);
            avl.insert(ref avl.root, 11);
            avl.insert(ref avl.root, 5);
            avl.insert(ref avl.root, 3);
           

            avl.delete(ref avl.root, 5);
        }

        class AVLNode
        {
            public int val;
            public AVLNode left;
            public AVLNode right;

            public AVLNode()
            {
                left = null;
                right = null;
            }

        }

        class Avltree
        {
            public AVLNode root;
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
                child.left = parent;
                return child;

            }
            AVLNode rotate_LL(AVLNode parent)
            {
                AVLNode child = parent.left;
                parent.left = child.right;
                child.right = parent;
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
            public AVLNode insert(ref AVLNode node, int num)
            {

                if (node == null)
                {
                    node = new AVLNode();
                    node.val = num;
                    node.left = null;
                    node.right = null;
                }
                else if (num < node.val)
                {
                    node.left = insert(ref node.left, num);
                    node = rebalance(node);
                }
                else
                {
                    node.right = insert(ref node.right, num);
                    node = rebalance(node);
                }

                return node;

            }
            public void delete(ref AVLNode root, int num)
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

                root = rebalance(root);
            }

        }





    }
}
