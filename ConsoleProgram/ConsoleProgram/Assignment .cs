using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 6. Операции присваивания
    class Assignment
    {
        public int Action()
        {
            Console.WriteLine("\t Операции присваивания: ");
            int a = 10;
            a += 10;                   // a = a + 10   (20)
            Console.WriteLine(a);
            a -= 4;                    // a = a - 4     (16)
            Console.WriteLine(a);
            a *= 2;                    // a = a * 2     (20)
            Console.WriteLine(a);
            a /= 8;                    // a = a / 8     (4) ???????
            Console.WriteLine(a);
            a <<= 4;                   // a = a << 4    (64)    1010    100 0000
            Console.WriteLine(a);
            a >>= 2;                   // a = a >> 2    (16)    1010    10 000
            Console.WriteLine(a);
            return 0;
        }
    }
}
