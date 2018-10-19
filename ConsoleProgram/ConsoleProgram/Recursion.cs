using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Recursion
    {
        public void Action()
        {
            Console.Write("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(x));
            Console.WriteLine(Fibonachi(x));
        }

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
