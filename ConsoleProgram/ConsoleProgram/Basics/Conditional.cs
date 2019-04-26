using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 8. Условные выражения и логические операции
    class Conditional
    {
        public int Action()
        {
            Console.WriteLine("\t Операции сравнения и Логические операции (bool)");
            int a = 10;
            int b = 4;
            int c = 5;
            int d = 6;
            bool e = a == b;                // false
            Console.WriteLine(e);
            Console.WriteLine(a != b);      // true
            Console.WriteLine(a < b);       // false
            Console.WriteLine(a > b);       // true
            Console.WriteLine(a >= b);      // true
            Console.WriteLine(a <= b);      // false
            Console.WriteLine(a <= 10);     // true

            bool x1 = (c > d) | (b < d);    // (false) | (true) --> true
            bool x2 = (c > d) | (b > d);    // (false) | (false) --> false

            bool x3 = (c > d) & (b < d);    // (false) | (true) --> false
            bool x4 = (c > d) & (b > d);    // (false) | (false) --> false
            bool x5 = (c < d) & (b < d);    // (true) | (true) --> true
            bool x6 = (a > b) || (b > c) || (c > d);
            Console.WriteLine($"|| : {x6}");

            string d1 = ("John");
            string d2 = ("John");
            Console.WriteLine(d1 == d2);
            return 0;
        }
    }
}
