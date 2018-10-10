using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Preobrazovanie
    {
        public int Action()     // метод 7
        {
            Console.WriteLine("\t Преобразования типов данных: ");
            byte a = 4;
            byte b = (byte)(a + 70);
            Console.WriteLine(b);
            double c = 33.0;
            decimal d = (decimal)c;
            Console.WriteLine(d);
            try
            {
                int e = 33;
                int f = 600;
                byte g = checked((byte)(e + f));     // выход за пределы допустимого типа byte
                Console.WriteLine(g);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Недопустимый диапазон");   //ловим ошибку
            }
            return 0;
        }
    }
}
