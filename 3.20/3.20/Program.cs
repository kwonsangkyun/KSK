using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._20
{

    public class Btree
    {

        class tree
        {
            public char val;
            public tree left=null;
            public tree right=null;
        }

        tree root=null;

        public void maketree(Queue<char> mq)
        {
            Stack<tree> st = new Stack<tree>();
            tree a;
            tree b;
            
            char c;

            while (mq.Count > 0) {
                c = mq.Dequeue();

                if (c >= '0' && c <= '9')
                    st.Push(createtree(c, null, null));
                else
                {
                    a = st.Pop();
                    b = st.Pop();
                   st.Push( createtree(c, b, a));
                }
    
            }

            Console.Write(postorder(st.Pop()));

        }
         tree createtree(char c, tree left, tree right)
        {
            tree r = new tree();
            r.val = c;
            r.left = left;
            r.right = right;

            return r;
        }

       
        void preorder2(tree cur)
        {
            Stack<tree> st = new Stack<tree>();
            
            st.Push(cur);
           
            while (st.Count>0)
            {
                if (cur != null)
                {
                    Console.Write(cur.val+" ");
                    st.Push(cur);
                    cur = cur.left;
                 
                }
                else
                    cur = st.Pop().right;
            }
           

        }

        void preorder(tree cur)
        {
            

            Console.Write(cur.val + " ");
            if(cur.left != null)
            preorder(cur.left);
            if (cur.right != null)
                preorder(cur.right);


        }

        void inorder(tree cur)
        {
            if (cur.left != null)
                inorder(cur.left);
            Console.Write(cur.val + " ");
            if (cur.right != null)
                inorder(cur.right);

        }
        int postorder(tree cur)
        {
            if (cur == null)
                return 0;
            if ((cur.left == null) && (cur.right == null))
                return cur.val - '0';
            else {
                int op1 =postorder(cur.left);
                int op2=postorder(cur.right);
                switch (cur.val)
                {
                    case '+':
                        return op1 +op2;
                    case '-':
                        return op1 - op2;
                    case '*':
                        return op1 * op2;
                    case '/':
                        return op1 / op2;
                 }
            }

            return 0;
        }
   }


   

    class Program
    {
        static void Main(string[] args)
        {
            Btree mtree = new Btree();
            Queue < char > mq = new Queue<char>();
          
            mq=ToPostFix("4+7*3+2");
          
            mtree.maketree(mq);

        }

        static Queue<char> ToPostFix(string s)
        {
            Queue<char> numst = new Queue<char>();
            Stack<char> token = new Stack<char>();
            int i=0;
            

            while (i<s.Length)
            {
                if (s[i] >= '0' && s[i] <= '9')
                    numst.Enqueue(s[i]);
                else
                {
                    if (token.Count == 0)
                        token.Push(s[i]);
                    else if (s[i] == '*' || s[i] == '/')
                        token.Push(s[i]);
                    else
                    {
                        while (token.Count > 0)
                            numst.Enqueue(token.Pop());
                        token.Push(s[i]);
                    }

                    
                }
                

                i++;
            }
            while (token.Count > 0)
                numst.Enqueue(token.Pop());
      
            return numst;
        }
    }
}
