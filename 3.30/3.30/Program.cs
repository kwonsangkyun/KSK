using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._30
{
    class Vector2
    {
        float x;
        float y;

        public Vector2()
        {
            x = 0;
            y = 0;
        }
        public Vector2(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
        public Vector2(Vector2 _vec) :this(_vec.x,_vec.y)
        {
        }           
        public void SetX(float _x)
        {
            x = _x;
        }
        public float GetX()
        {
            return x;
        }
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public static Vector2 operator +(Vector2 _a,Vector2 _b)  // 연산자 오버로딩
        {
            return new Vector2(_a.x+_b.x,_a.y+_b.y);
        }
        public static Vector2 operator -(Vector2 _a, Vector2 _b)  // 연산자 오버로딩
        {
            return new Vector2(_a.x - _b.x, _a.y - _b.y);
        }
        public static Vector2 operator *(Vector2 _a, Vector2 _b)  // 연산자 오버로딩
        {
            return new Vector2(_a.x * _b.x, _a.y * _b.y);
        }
        public static Vector2 operator /(Vector2 _a, Vector2 _b)  // 연산자 오버로딩
        {
            return new Vector2(_a.x / _b.x, _a.y / _b.y);
        }
        public static bool operator ==(Vector2 _a, Vector2 _b)  // 연산자 오버로딩
        {
            if (_a.x == _b.x && _a.y == _b.y)
                return true;
            else
                return false;
        }
        public static bool operator !=(Vector2 _a, Vector2 _b)  // 연산자 오버로딩
        {
            if (_a.x == _b.x && _a.y == _b.y)
                return false;
            else
                return true;
        }
        public static float dot(Vector2 _a, Vector2 _b)
        {
            return (_a.x * _b.x) + (_a.y + _b.y);
        }

    }
    class A
    {
        int[] arr;
        public A()
        {
            arr = new int[100];    
        }

        public void Set(int index, int value)
        {
            if (index >= 0 && index < arr.Length)
                arr[index] = value;
            else
                Console.WriteLine("index Boundary Error");

        }
        public int Get(int index)
        {
            if (index >= 0 && index < arr.Length)
                return arr[index];
            else
            {
                Console.WriteLine("index Boundary Error");
                return -1;
            }
        }

    }
    interface ILogger
    {
        void WriteLog(string log);
    }
    class Program
    {
        delegate int Compare(Student a,Student b);
      

        static void Main(string[] args)
        {

            /*
            Vector2 vec1 = new Vector2(1.0f, 1.0f);
            Vector2 vec2 = new Vector2(1.2f, 1.2f);
            Vector2 vec3 = new Vector2(1.5f, 1.5f);
            vec1.Y += 1;
            

            //Vector2 sumvec = vec1.Sum(vec2).Sum(vec3);
            //sumvec = sumvec.Sum(vec3);
          
            Console.WriteLine(vec1.GetX());
            Console.WriteLine(vec1.Y);
           */
        

            //Console.WriteLine(students.total);
            Manager _manager = new Manager();
           Compare compare = new Compare(_manager.numbercompare);
           _manager.sort(ref _manager.students, compare);


            
        }

        class Student
        {
            public int number;
            public string name;
            public int total;
            public double averagescore;
            static int i = 0;
            public Student()
            {
                Random rand = new Random();

                    number =5-i;
                    total = 5-i;
                    name = "a" + i++;
                    averagescore = rand.NextDouble();
                
            }
        }

        class Manager
        {
            public Student[] students; 

           

            public Manager()
            {
                //Random rand = new Random();
                students = new Student[5];
                for (int i = 0; i < students.Length; ++i)
                {
                    students[i] = new Student();
                }


            }
            public int numbercompare(Student a,Student b)
            {
                if (a.number > b.number)
                    return 1;
                else
                    return 0;
            }
            public int floatcompare(Student a, Student b)
            {
                if (a.averagescore > b.averagescore)
                    return 1;
                else
                    return 0;

            }
            public int totalcompare(Student a, Student b)
            {
                if (a.total > b.total)
                    return 1;
                else
                    return 0;
            }
            public int StringCompare(Student a, Student b)
            {
                if (string.Compare(a.name, b.name) > 0)
                    return 1;
                else
                    return 0;
            }
           public void sort(ref Student[] st,Compare compare)
            {
                Student temp;
                for (int i = 0; i < st.Length - 1; ++i)
                {
                    for (int j = 0; j < st.Length - (i + 1); j++)
                    {
                        if (compare(st[j], st[j + 1]) > 0)
                        {
                            temp = st[j + 1];
                            st[j + 1] = st[j];
                            st[j] = temp;
                        }

                    }
                }

                Console.WriteLine();
                
                
            }

        }
    }
}
