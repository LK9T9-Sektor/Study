using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Convertator
    {
        public int Chisla()    // здесь хранится переведенное число
        {
            Console.Write("Введите число в 10-й системе: ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите систему счисления (2, 8, 10, 16): ");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(c1, d1));
            return c1;
        }
    }
}
