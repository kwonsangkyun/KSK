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

            avl.insert(9);
            avl.insert(8);
            avl.insert(11);
            avl.insert(5);
            avl.insert(3);
            avl.insert(1);
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
             AVLNode root=null;

           
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


           public void insert(int num)
            {
                AVLNode temp = new AVLNode();
                AVLNode cur = root;
                AVLNode parent = cur;

                temp.val = num;
                temp.left = null;
                temp.right = null;
               
                if (root == null)
                    root = temp;
                else
                {
                    while (cur != null)
                    {
                        parent = cur;
                        if (num < cur.val)
                            cur = cur.left;
                        else
                            cur = cur.right;
                    }
                    if (num < parent.val)
                        parent.left = temp;
                    else
                        parent.right = temp;

                    parent =rebalance(parent);
                }

            }
        }
        
      


      
    }
}
