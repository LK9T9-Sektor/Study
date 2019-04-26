using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Куча различных функций
namespace ConsoleProgram
{
    // 1. Получение данных из кучи различных функций
    class Bunch
    {
        public int OfThings ()
        {
            // Получение Типа указанного значения
            Console.WriteLine(1.0.GetType());
            Console.WriteLine(1E06.GetType());
            Console.WriteLine(0x1000000000.GetType());
            Console.WriteLine(0xF0000000.GetType());
            /* представление числа в 2, 8, 10, 16 системах счисления
            Convert.ToString(число, счисление) */
            Console.WriteLine(Convert.ToString(0b1011, 10));

            int intValue3 = 0b0001_0110_0011_0100_0010;         // 90946 в 2-ичной
            Console.WriteLine(intValue3);
            // Вывод макс. возможного int значения
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            int a = int.MaxValue;
            Console.WriteLine(a + 1);                                   // переполнение max+1
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            /* вывод (указатель уйдёт в начало стека = min число) */
            return 0;
        }
    }
}
