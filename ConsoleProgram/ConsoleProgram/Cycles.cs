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
            Console.Write("Декримент числа до: ");
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

            start:                                                  // метка для возвращения
            Console.WriteLine("\t\tИспользование break и continue");
            Console.Write("Введите начальное число цикла: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечное число цикла: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число выхода из цикла: ");       // break
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число для пропуска в цикле: ");  // continue
            int j = Convert.ToInt32(Console.ReadLine());
            if (e < f)                                              // условия для выполнения инкремента
            {
                for (int h = e; h < g; h++)
                {
                    if (h == j)
                        continue;                                   // пропускаем введеное число
                    if (h == f)
                        break;                                      // останавливаем цикл
                    Console.WriteLine($"{h}");
                }
            }
            else if (e > f)                                         // условие для выполнения декримента
            {
                for (int h = e; h > g; h--)
                {
                    if (h == j)
                        continue;
                    if (h == f)
                        break;
                    Console.WriteLine($"{h}");
                }
            }
            else
            {
                Console.WriteLine("Числа равны!");
                goto start;                                         // вернуться по метке на ввод
            }

            Console.WriteLine("\t\tБесконечный инкрементный цикл");
            Console.WriteLine("Напоминание: макс. число для Int32: {0}", Int32.MaxValue);
            Console.Write("Введите число для выхода из бесконечного цикла: ");
            int l = Convert.ToInt32(Console.ReadLine());
            int m = 0;
            for( ; ; )
            {
                m++;
                Console.WriteLine(m);
                if (m == l)                                         // число остановки цикла
                break;
            }
            
            Console.WriteLine("\t\tФакториал");
            Console.Write("Введите конечное число факториала: ");
            /* n + 1 <-- переменная конечного числа факториала,
             * +1, т.к. должно на нём закончится, а не до него */
            ulong n = Convert.ToUInt64(Console.ReadLine())+1;       
            ulong q = 1;                                            // переменная результата, q
            Console.WriteLine("Для вывода конечного ответа, введите: 1 \n" +
                "Для вывода всех шагов, введите любой другой символ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                    for (ulong p = 1; p < n; q *= p++) ;                     // q = q * p++ и т.д. по кругу до n
                    Console.WriteLine($"Факториал !{n - 1} = {q}");           // n-1 <-- вернём n исходное число                    
            }
            else
            {
                for (ulong p = 1; p < n; p++)
                {
                    q *= p;
                    Console.WriteLine($"!{p} = {q}");
                }
            }
                                                             
            return 0;
        }
    }
}