using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Construkcii
    {
        public int Action()       // метод 9
        {
            Console.WriteLine("\t Условные конструкции if/else; switch/case");
            int a = 8;
            int b = 6;

            if (a > b)
            {
                Console.WriteLine($"{a} > {b}");
            }

            int c = 8;
            int d = 6;

            if (c < d)
            {
                Console.WriteLine($"{c} < {d}");
            }
            else
            {
                Console.WriteLine("Выполняется else");
            }

            Console.Write("Введите 1 число: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int f = Convert.ToInt32(Console.ReadLine());

            if (e > f)
                Console.WriteLine($"if: \n{e} > {f}");
            else if (e == f)
                Console.WriteLine($"else if: \n{e} = {f}");
            else
                Console.WriteLine($"else: \n{e} < {f}");

            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Буква Y");
                    break;
                case "N":
                    Console.WriteLine("Буква N");
                    break;
                default:
                    Console.WriteLine("Неизвестная буква");
                    break;
            }

            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    goto case 3; // переход к case 5
                case 2:
                    Console.WriteLine("case 2");
                    return -1;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или любой другой символ");
            string sel = Console.ReadLine();
            /*
            int z;
            if (sel == "+")
            {
                z = (x + y);
            }
            else
            {
                z = (x - y);
            }
            */

            int z = sel == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

            return 0;
        }
    }
}