using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class PoRazryad
    {
        public int Action()
        {
            Console.WriteLine("\t & (Логическое умножение И):");
            int x1 = 2; //010
            int x2 = 5; //101
            Console.WriteLine(x1 & x2);
            int y1 = 4; //100
            int y2 = 5; //101
            Console.WriteLine(y1 & y2);

            Console.WriteLine("\t | (Логическое сложение ИЛИ):");
            int x3 = 2;
            int x4 = 5;
            Console.WriteLine(x3 | x4);

            Console.WriteLine("\t ^ (логическое исключающее ИЛИ) XOR:");
            int x = 45; // Значение, которое надо зашифровать - в двоичной форме 101101
            int key = 102; //Пусть это будет ключ - в двоичной форме 1100110
            int encrypt = x ^ key; //Результатом будет число 1001011 или 75
            Console.WriteLine("Зашифрованное число: " + encrypt);
            int decrypt = encrypt ^ key; // Результатом будет исходное число 45
            Console.WriteLine("Расшифрованное число: " + decrypt);

            Console.WriteLine("\t ~ (логическое отрицание, инверсия) НЕ:");
            int y = 12;                         // 00001100
            Console.WriteLine($"12:  { ~y}");   // 11110011     или -13

            Console.WriteLine("\t Представление отрицательного числа:");
            int a = 12;                         // 00001100
            int b = ~a;                         // 11110011     или -13
            b += 1;
            Console.WriteLine(Convert.ToString(a, 2));  // представление числа 12 в двоичной системе
            Console.WriteLine(b);   // -12

            Console.WriteLine("\t Операции сдвига << - влево, >> - вправо:");
            int c = 16;
            int d = c << 1;         // сдвиг влево на 1 разряд  (умножение на 2)
            int e = c >> 1;         // сдвиг вправо на 1 разряд (деление на 2)
            Console.WriteLine($"{d} - сдвиг влево, умножение на 2");
            Console.WriteLine($"{e} - сдвиг вправо, деление на 2");
            return 0;
        }
    }
}
