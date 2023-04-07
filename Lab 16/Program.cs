using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16
{
    internal class Program
    {
        public delegate float Function(int x);

        static float Fun1(int x) => 1f / Step(x);

        static float Step(int x)
        {
            if (x == 0) return 1;
            else return Step(x - 1) * 2.72f;
            // e = 2.72
        }

        static float Fun2(int x) => 1f / Math.Abs(x);

        static float Fun3(int x) => (1f / x) *(float)Math.Cos(x * Math.PI / 180);

        static void Main(string[] args)
        {
            Console.Write("=> ");
            
            if (Console.ReadKey().Key == ConsoleKey.M)
            {
                Console.Write("ykhailo");
                Console.WriteLine();


                Console.Write("Input: x(b) = ");
                int xb = int.Parse(Console.ReadLine());

                Console.Write("Input: x(a) = ");
                int xa = int.Parse(Console.ReadLine());

                Function fun1 = new Function(Fun1);
                float result1 = fun1(xb) - fun1(xa);
                Console.WriteLine("Function 1 = " + result1);

                Function fun2 = new Function(Fun2);
                float result2 = fun2(xb) - fun1(xa);
                Console.WriteLine("Function 2 = " + result2);

                Function fun3 = new Function(Fun3);
                float result3 = fun3(xb) - fun1(xa);
                Console.WriteLine("Function 3 = " + result3);
            }
            Console.Read();
        }
    }
}
