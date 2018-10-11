using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Cycles
    {
        public int Action()
        {
            Console.WriteLine("\t\tИспользование цикла for (инкремент)");
            Console.Write("Выведение квадратов чисел, до числа: ");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<k+1; i++)
            {
                Console.WriteLine($"{i}*{i}= {i * i}");
            }
            Console.WriteLine("\t\tИспользование цикла for while (декримент)");
            Console.Write("Начать декримент с числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Декримент числа до (while): ");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a > b-1)
            {
                Console.WriteLine(a);
                a--;
            }
            Console.WriteLine("\t\tИспользование цикла do while");
            int c = -4;
            Console.Write("-4 > ");
            int d = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(c);
                c--;
            }
            while (c > d);

            Console.WriteLine("\t\tИспользование break");
            Console.Write("Введите начальное число цикла: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечное число цикла: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число выхода из цикла: ");
            int g = Convert.ToInt32(Console.ReadLine());
            if (e < f)
            {
                for (int h = e; h < g; h++)
                {
                    if (h == f)
                        break;
                    Console.WriteLine($"{h}");
                }
            }
            else if (e > f)
            {
                for (int h = e; h > g; h--)
                {
                    if (h == f)
                        break;
                    Console.WriteLine($"{h}");
                }
            }
            else
            {
                Console.WriteLine("Числа равны");
            }

            
            return 0;
        }
    }
}
