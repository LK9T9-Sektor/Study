using System;                               //namespace, пространства имен, из библиотек находящихся по адресу: C:\Windows\assembly
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram                    //пространство имен ConsoleApp3
{
    class Program                           // класс Program в namespace ConsoleApp3 (ConsoleApp3.Program)
    {
        static void Main(string[] args)     // точка входа, метод Main, static - статистический, void - ничего не возвращает (метод №0)
        {                                   // блок операторов {}
            Console.Title = "Обучение";     // заголовок программы
        start:                              // метка start:
            Console.WriteLine("\t\t\tВыберите метод: \n" +
                "1. Получение данных из кучи различных функций\n" +
                "2. Неявная типизация, получение типа переменной\n" +
                "3. Получение данных о переполнении переменной\n" +
                "4. Конвертация чисел из 10-ой системы счисления в 2, 8, 10, 16\n" +
                "5. Поразрядные операции\n" +
                "6. Операции присваивания\n" +
                "7. Преобразование базовых типов + try/catch\n" +
                "8. Условные выражения и логические операции\n" +
                "9. Условные конструкции\n" +
                "10. Циклы for/do/while. Операторы continue/break\n" +
                "11. Массивы, цикл foreach, операторы Length, GetUpperBound\n" +
                "12. Методы\n" + 
                "13. Параметры методов. Необязательные и именованные параметры\n" +
                "14. Передача входных параметров по значению и ссылке (ref)\n" +
                "15. Выходные параметры (out)\n" +
                "16. Ключевое слово params. Массив параметров\n");
        select:
            Console.WriteLine("_________________________________________________________________");
            Console.Write("Выход из программы: 0. Отображения списка методов: ?\nВведите номер метода: ");
            //int selection = Convert.ToInt32(Console.ReadLine());
            string selection = Console.ReadLine();
            Console.Clear();                // очистка консоли
            switch (selection)
            {
                case "?":
                    goto start;                                // переход к метке start:
                case "0":
                    Environment.Exit(0);                       // закрытие программы и передача кода 0
                    break;
                case "1":
                    Console.WriteLine("_______________Получение данных из Bunch.cs_____________________");
                    //Bunch bunch = new Bunch();
                    Console.WriteLine(new Bunch().OfThings());
                    goto select;
                case "2":
                    Console.WriteLine("_______________Получение данных из Neyavnaya.cs__________________");
                    Console.WriteLine(new Neyavnaya().Peremenaya());
                    goto select;
                case "3":
                    Console.WriteLine("_______________Получение данных из Overflow.cs__________________");
                    Overflow overflow = new Overflow();
                    Console.WriteLine(overflow.Action());
                    //int meth_2 = Overflow();
                    //Console.WriteLine($"Из метода №2: {Overflow()}");
                    //Console.WriteLine(meth_2);
                    goto select;
                case "4":
                    Console.WriteLine("_______________Получение данных из Convertator.cs_______________");
                    Convertator convertator = new Convertator();        // создаём экземпляр нашего класса
                    Console.WriteLine(new Convertator().Chisla());      // вызываем метод экземпляра класса и получаем ответ ()
                    // Далее не обязательно
                    //int z1;                                  // переменная для получения результата
                    //z1 = Convertator.Chisla();               // переданное значение присваиваем в переменнуюю z
                    //Console.WriteLine(z1.GetType());         // получение типа переменной
                    goto select;
                case "5":
                    Console.WriteLine("_______________Получение данных из PoRazryad.cs__________________");
                    Console.WriteLine(new PoRazryad().Action());
                    goto select;
                case "6":
                    Console.WriteLine("_______________Получение данных из Prisvaivanie.cs_______________");
                    Console.WriteLine(new Prisvaivanie().Action());
                    goto select;
                case "7":
                    Console.WriteLine("_______________Получение данных из Preobrazovanie.cs_____________");
                    Console.WriteLine(new Preobrazovanie().Action());
                    goto select;
                case "8":
                    Console.WriteLine("_______________Получение данных из Uslovnie.cs___________________");
                    Console.WriteLine(new Uslovnie().Action());
                    goto select;
                case "9":
                    Console.WriteLine("_______________Получение данных из Construkcii.cs________________");
                    Console.WriteLine(new Construkcii().Action());
                    goto select;
                case "10":
                    Console.WriteLine("_______________Получение данных из Cycles.cs_____________________");
                    Console.WriteLine(new Cycles().Action());
                    goto select;
                case "11":
                    Console.WriteLine("_______________Получение данных из Array.cs______________________");
                    Console.WriteLine(new Array().Action());
                    goto select;
                case "12":
                    Console.WriteLine("_____________________Внутренний метод 12_________________________");
                    Method12();
                    //Console.WriteLine(new Array().Action());
                    goto select;
                 case "13":
                    Console.WriteLine("_____________________Внутренний метод 13_________________________");
                    Method13();
                    goto select;
                 case "14":
                    Console.WriteLine("_____________________Внутренний метод 14_________________________");
                    Method14();
                    goto select;
                  case "15":
                    Console.WriteLine("_____________________Внутренний метод 15_________________________");
                    Method15();
                    goto select;
                  case "16":
                    Console.WriteLine("_____________________Внутренний метод 16_________________________");
                    Method16();
                    goto select;
                default:
                    Console.WriteLine("Неверный метод, попробуйте ещё раз!");
                    goto select;
            }
        }

        static void Method12()             // используется для вызова методов внутри
        {
            Console.WriteLine("Возвращение значения из метода");
            int mthd = Give_a();
            Console.WriteLine(Give_a());
            Small();
            Console.WriteLine(SmallRet());
        }
        
        static void Method13()             // используется для вызова методов внутри
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
            int ab = OptionalParams(a1:5, b1:6);
            Console.WriteLine("5 - 6 * 3 + 10 = {0}", ab);
            int abd = OptionalParams(b1:6, a1:5, d1:5);
            Console.WriteLine("6 - 5 * 3 + 5 = {0}", abd);
        }
        
        static void Method14()             // используется для вызова методов внутри
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

        static void Method15()             // используется для вызова методов внутри
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

        static int Give_a()             // относится к 12 методу
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

        static void Method16()          // используется для вызова методов внутри и из Parameters.cs
        {
            Console.WriteLine("\tПередача и получение внутри Program.cs");
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

        
        public void All()
        {
            Console.WriteLine();
            Console.ReadKey();                  // чтобы консоль не сразу закрывалась
        }
    }
}