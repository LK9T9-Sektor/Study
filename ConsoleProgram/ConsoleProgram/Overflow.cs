using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Overflow
    {
        public int Action()                              // метод 2, целочисленное переполнение
        {
            int b = int.MinValue;
            Console.WriteLine($"Минимальное значение для Int: {b}");
            b--;
            Console.WriteLine($"После операции инкремента (- -) Int: {b}");
            Console.WriteLine(b == int.MaxValue);       // булевское сравнение, b = макс. значению int?
            return b;
        }
    }
}
