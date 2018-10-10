using System;                       //namespace, пространства имен, из библиотек находящихся по адресу: C:\Windows\assembly
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3               //пространство имен ConsoleApp3
{
    class Program                   // класс Program в namespace ConsoleApp3 (ConsoleApp3.Program)
    {
        static void Main(string[] args)     // точка входа, метод Main, static - статистический, void - ничего не возвращает (метод №0)
        {                                   // блок операторов {}
            Console.WriteLine(1.0.GetType());
            Console.WriteLine(1E06.GetType());
            Console.WriteLine(0x1000000000.GetType());
            Console.WriteLine(0xF0000000.GetType());
            Console.WriteLine(Convert.ToString(0b1011, 10));    /* представление числа в 2, 8, 10, 16 системах счисления
                                                                Convert.ToString(число, счисления) */
            int intValue3 = 0b0001_0110_0011_0100_0010;         // 90946 в 2-ичной
            Console.WriteLine(intValue3);
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            int a = int.MaxValue;
            Console.WriteLine(a + 1);
            Console.WriteLine("Max of double: {0}", double.MaxValue);

            Console.WriteLine("_______________Получение данных из Convertator.cs____________________");
            Convertator convertator = new Convertator();        // создаём экземпляр нашего класса
            Console.WriteLine(convertator.Chisla());    // вызываем метод экземпляра класса и получаем ответ ()
            // Далее не обязательно
            //int z1;                                  // переменная для получения результата
            //z1 = perevod.Chisla();                   // переданное значение присваиваем в переменнуюю z
            //Console.WriteLine(z1.GetType());         // получение типа переменной

            Console.WriteLine("____________________________________________________________");
            var e = 5;
            Console.WriteLine($"var С равно: {e}");
            e = 6;
            Console.WriteLine($"Тип для var С: {e.GetType().ToString()}");
            Console.WriteLine(e);
            Console.WriteLine("____________________________________________________________");
            // получаем данные из метода №1
            int meth_1 = First();
            Console.WriteLine($"Из метода №1: {First()}");
            Console.WriteLine(meth_1);
            Console.WriteLine("____________________________________________________________");
            // получаем данные из метода №2
            int meth_2 = Overflow();
            Console.WriteLine($"Из метода №2: {Overflow()}");
            Console.WriteLine(meth_2);
            Console.WriteLine("____________________________________________________________");
            // получаем данные из метода №3
            Console.WriteLine(Method3());   // краткая запись
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("Поразрядные операции:");
            int meth_4 = PoRazryad();
            //Console.WriteLine($"Из метода №4: {PoRazryad()}");
            //Console.WriteLine(meth_4);
            Console.WriteLine("____________________________________________________________");
            int meth_5 = Predvstavlenie();
            Console.WriteLine("____________________________________________________________");
            int meth_6 = Prisvaivanie();
            Console.WriteLine("____________________________________________________________");
            int meth_7 = Preobrazovanie();
            Console.WriteLine("____________________________________________________________");
            int meth_8 = Uslovnie();
            Console.WriteLine("____________________________________________________________");
            int meth_9 = Construkcii();

            Console.ReadKey();              // чтобы консоль не сразу закрывалась
        }
        static int First()                 // метод 1
        {
            int a = 12;
            return a;                // return - возвращает значение и выходит из метода, всё что будет ниже не сработает!
        }
        static int Overflow()                              // метод 2, целочисленное переполнение
        {
            int b = int.MinValue;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);
            Console.WriteLine(b == int.MaxValue);
            return b;
        }
        static string Method3() => ("Сокращенная запись метода");   // метод 3

        static int PoRazryad()                                      // метод 4
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
            Console.WriteLine($"{ d} - сдвиг влево, умножение на 2");
            Console.WriteLine($"{e} - сдвиг вправо, деление на 2");
            return 0;
        }
        private static int Predvstavlenie()     // метод 5, представление десятичных чисел в 2-, 8-, 10-, 16- ичном формате (мой)
        {
            Console.Write("Введите число в 10-й системе: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите систему счисления (2, 8, 10, 16): ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(x, y));
            return x;
        }
        private static int Prisvaivanie()     // метод 6
        {
            Console.WriteLine("\t Операции присваивания: ");
            int a = 10;
            a += 10;                   // a = a + 10   (20)
            Console.WriteLine(a);
            a -= 4;                    // a = a - 4     (16)
            Console.WriteLine(a);
            a *= 2;                    // a = a * 2     (20)
            Console.WriteLine(a);
            a /= 8;                    // a = a / 8     (4) ???????
            Console.WriteLine(a);
            a <<= 4;                   // a = a << 4    (64)    1010    100 0000
            Console.WriteLine(a);
            a >>= 2;                   // a = a >> 2    (16)    1010    10 000
            Console.WriteLine(a);
            return 0;
        }
        private static int Preobrazovanie()     // метод 7
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
        private static int Uslovnie()       // метод 8
        {
            Console.WriteLine("\t Операции сравнения и Логические операции (bool)");
            int a = 10;
            int b = 4;
            int c = 5;
            int d = 6;
            bool e = a == b;                // false
            Console.WriteLine(e);
            Console.WriteLine(a != b);      // true
            Console.WriteLine(a < b);       // false
            Console.WriteLine(a > b);       // true
            Console.WriteLine(a >= b);      // true
            Console.WriteLine(a <= b);      // false
            Console.WriteLine(a <= 10);     // true

            bool x1 = (c > d) | (b < d);    // (false) | (true) --> true
            bool x2 = (c > d) | (b > d);    // (false) | (false) --> false

            bool x3 = (c > d) & (b < d);    // (false) | (true) --> false
            bool x4 = (c > d) & (b > d);    // (false) | (false) --> false
            bool x5 = (c < d) & (b < d);    // (true) | (true) --> true
            bool x6 = (a > b) || (b > c) || (c > d);
            Console.WriteLine($"|| : {x6}");

            string d1 = ("John");
            string d2 = ("John");
            Console.WriteLine(d1 == d2);
            return 0;
        }
        private static int Construkcii()       // метод 9
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
            Console.WriteLine("Нажмите + или любой другой символ");       // 
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
