using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Neyavnaya
    {
        public int Peremenaya()
        {
            Console.Write("Введите число d: ");
            var d = Console.ReadLine();
            Console.WriteLine($"Тип для var d: {d.GetType().ToString()}");
            Console.WriteLine($"Значение для d после переприсвоения +1: {d += 1}");
            var e = 5;
            Console.WriteLine($"var e равно: {e}");
            e = 6;
            Console.WriteLine($"Тип для var e: {e.GetType().ToString()}");      // получение типа
            Console.Write("Значение для e после переприсвоения: ");
            return e;
        }
    }
}
