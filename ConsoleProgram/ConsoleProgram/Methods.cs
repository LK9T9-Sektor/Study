using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Methods
    {
        // 12. Методы
        public void Method12()
        {
            Console.WriteLine("Возвращение значения из метода");
            int mthd = Give_a();
            Console.WriteLine(Give_a());
            Small();
            Console.WriteLine(SmallRet());
        }
        // 13. Параметры методов. Необязательные и именованные параметры
        public void Method13()
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 3;
            int result = Sum(a, b);
            Console.WriteLine(result);
            result = Sum(a, 150);
            Console.WriteLine($"{a} + 150 = " + result);
            result = Sum(a + b + 10, 18);           // "x = a + b + 10", "y = 18"
            Console.WriteLine(result);

            Console.WriteLine("\tstatic void Display(string name, int age)");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Display(name, age);

            // OptionalParams(a, b);
            Console.WriteLine("\tНеобязательные параметры");
            int prm = OptionalParams(a, b);
            Console.WriteLine("{0} - {1} * 3 + 10 = {2}", a, b, prm);
            prm = OptionalParams(a, b, 4);
            Console.WriteLine("{0} - {1} * 4 + 10 = {2}", a, b, prm);

            Console.WriteLine("\tИменованные параметры");
            int ab = OptionalParams(a1: 5, b1: 6);
            Console.WriteLine("5 - 6 * 3 + 10 = {0}", ab);
            int abd = OptionalParams(b1: 6, a1: 5, d1: 5);
            Console.WriteLine("6 - 5 * 3 + 5 = {0}", abd);
        }
        // 14. Передача входных параметров по значению и ссылке (ref)
        public void Method14()
        {
            Console.WriteLine("\tx = x + y \tили \t(x = z + d)");
            int z = 5;
            int d = 6;
            Console.WriteLine($"Начальное значение z = {z} \t (x)");
            Console.WriteLine($"Начальное значение d = {d} \t (y)");
            Console.WriteLine("\tПередача параметров по значению"); // копия переменной z
            AdditionalVal(z, d);
            Console.WriteLine($"Конечное значение z = {z} \t (x)");
            Console.WriteLine($"Конечное значение d = {d} \t (y)");

            Console.WriteLine("\tПередача параметров по ссылке (ref)");   // а тут прямо в ячейку памяти с z = x
            AdditionalRef(ref z, d);
            Console.WriteLine($"Конечное значение z = {z} \t (x)");
            Console.WriteLine($"Конечное значение d = {d} \t (y)");
        }
        // 15. Выходные параметры (out)
        public void Method15()
        {
            Console.WriteLine("\t\tРасчёт площади и периметра прямоугольника");
            Console.Write("Введите ширину: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите высоту: ");
            int h = Convert.ToInt32(Console.ReadLine());
            int perimeter;
            int area;
            PerimArea(w, h, out area, out perimeter);
            Console.WriteLine($"Площадь = {area}");
            Console.WriteLine($"Периметр = {perimeter}");
        }
        // 12: возвращает значение переменной a
        static int Give_a()
        {
            int a = 12;
            return a;                   // return - возвращает значение и выходит из метода, всё что будет ниже не сработает!
        }

        static void Small() => Console.WriteLine("Сокращенная запись метода");

        static string SmallRet() => "Возвращение значения (return) в сокращенной записи метода";    // return "текст";
        // 13
        static int Sum(int x, int y)
        {
            return x + y;
        }
        // через данный метод можно отображать string и int, т.е. замена постоянному написанию Console.WriteLine
        static void Display(string name, int age)   // 13
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
        // 13
        static int OptionalParams(int a1, int b1, int c1 = 3, int d1 = 10)
        {
            return a1 - b1 * c1 + d1;
        }
        // 14
        static void AdditionalVal(int x, int y)         // передача по значению
        {
            x = x + y;
            Console.WriteLine($"Результат суммы,  x = {x}  \t (x + y)");
        }
        // 14
        static void AdditionalRef(ref int x, int y)     // передача по ссылке (ref)
        {
            x = x + y;
            Console.WriteLine($"Результат суммы,  x = {x}  \t (x + y)");
        }
        // 15
        static void PerimArea(int width, int height, out int area, out int perimeter)     // out
        {
            perimeter = (width + height) * 2;
            area = width * height;
        }
        // 16. Ключевое слово params. Массив параметров
        public void Method16()          // используется для вызова методов внутри и из Parameters.cs
        {
            Console.WriteLine("\tПередача и получение внутри Methods.cs");
            // передача через params
            Console.WriteLine("Передача params");
            Addition(new int[] { 1, 2, 3, 4 });
            Addition(2, 3, 4, 5);
            Addition();
            // передача массива, 1 способ
            Console.WriteLine("Передача массива");
            AdditionMass(new int[] { 1, 2, 3, 4 });
            AdditionMass(new int[] { 2, 3, 4, 5 });
            AdditionMass(new int[] { });
            // 2 способ
            int[] array = new int[] { 1, 2, 3, 4 };
            AdditionMass(array);
            //int[] array = new int[] { 3, 3, 3, 3 };
            //AdditionMass(array);
            Console.WriteLine("\tПередача и получение из Parameters.cs");
            new Parameters().Addition(1, 2, 3, 4);
        }
        // 16
        static void Addition(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
        // 16
        static void AdditionMass(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
    }
}
