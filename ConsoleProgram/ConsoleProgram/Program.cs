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
                "12. Методы. Необязательные и именованные параметры. Передача параметров по ссылке и значению\n");
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
                    Console.WriteLine("_______________Получение данных из Methods.cs_____________________");
                    Method0_5();
                    //Console.WriteLine(new Array().Action());
                    goto select;
                default:
                    Console.WriteLine("Неверный метод, попробуйте ещё раз!");
                    goto select;
            }
        }

        static void Method0_5()
        {
            int mthd = Method1();
            Console.WriteLine(Method1());
            Method2();
            Console.WriteLine(Method3());

            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 3;
            int result = Sum(a, b);
            Console.WriteLine(result);
            result = Sum(a, 150);
            Console.WriteLine($"{a} + 150 = " + result);
            result = Sum(a + b + 10, 18);           // "x = a + b + 10", "y = 18"
            Console.WriteLine(result);

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Display(name, age);

            //OptionalParams(a, b);
            int prm = OptionalParams(a, b);
            Console.WriteLine(prm);
            prm = OptionalParams(a, b, 4);
            Console.WriteLine(prm);

            int z = 5;
            int d = 6;
            Console.WriteLine($"InititalVal z = {z}");
            Console.WriteLine("\tПередача параметров по значению"); // копия переменной z
            AdditionalVal(z, d);
            Console.WriteLine($"After AdditinalVal z = {z}");

            Console.WriteLine("\tПередача параметров по ссылке");   // а тут прямо в ячейку памяти с z = x
            AdditionalRef(ref z, d);
            Console.WriteLine($"After AdditinalRef z = {z}");
        }

        static int Method1()            // метод 1
        {
            Console.Write("Возвращение значения из метода");
            int a = 12;
            return a;                   // return - возвращает значение и выходит из метода, всё что будет ниже не сработает!
        }

        static void Method2() => Console.WriteLine("Сокращенная запись метода");

        static string Method3 () => "Возвраешние значения (return) в сокращенной записи метода";    // return "текст";

        static int Sum(int x, int y)
        {
            return x + y;
        }
        // через данный метод можно отображать string и int, т.е. замена постоянному написанию Console.WriteLine
        static void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }

        static int OptionalParams(int a1, int b1, int c1 = 3, int d1 = 10)
        {
            return a1 - b1 * c1 + d1;
        }

        static void AdditionalVal(int x, int y)         // передача по значению
        {
            x = x + y;
            Console.WriteLine($"AdditionalVal x ={x}");
        }

        static void AdditionalRef(ref int x, int y)     // передача по ссылке
        {
            x = x + y;
            Console.WriteLine($"AdditionalRef x ={x}");
        }

        public void All()
        {
            Console.WriteLine(Method1());       // краткая запись вызова из метода
            Console.ReadKey();                  // чтобы консоль не сразу закрывалась
        }
    }
}