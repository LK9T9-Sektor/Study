using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 4. Конвертация чисел из 10-ой системы счисления в 2, 8, 10, 16
    class Convertator
    {
        public int Numbers()    // здесь хранится переведенное число
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
