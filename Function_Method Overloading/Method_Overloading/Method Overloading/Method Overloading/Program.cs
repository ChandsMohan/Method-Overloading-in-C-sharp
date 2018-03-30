using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method_Overloading
{
    class Program
    {
        public int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public int Sum(int a, int b, int c)
        {
            int result = a + b + c;
            return result;
        }
        private float Sum(float a, float b)
        {
            float res = a + b;
            return res;
        }
        private float Sum(float a, float b, float c)
        {
            float res = a + b + c;
            return res;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("The sum of Two Integers are:{0}", obj.Sum(12, 14));
            Console.WriteLine("The sum of Three Integers are:{0}",obj.Sum(15, 25, 27));
            Console.WriteLine("The sum of Two Floats are:{0}",obj.Sum(4.5f, 6.5f));
            Console.WriteLine("The sum of Three Floats are:{0}",obj.Sum(5.9f, 6.7f, 8.5f));
            Console.Read();
        }
    }
}
