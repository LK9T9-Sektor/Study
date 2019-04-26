using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 18. Рекурсивные функции (Факториал, число Фибоначи)
    class Recursion
    {
        public void Action()
        {
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Факториал: ");
            Console.WriteLine(Factorial(x));
            Console.Write("Числов Фибоначи: ");
            Console.WriteLine(Fibonachi(x));
        }
        // Факториал
        static int Factorial (int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }

        }
        // Число Фибоначи
        static int Fibonachi (int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(x - 1) + Fibonachi(x - 2);
            }
        }
    }
}
