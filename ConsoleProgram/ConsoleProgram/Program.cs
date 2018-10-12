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
                "11. Массивы, цикл foreach, операторы Length, GetUpperBound");
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
                    Console.WriteLine("_______________Получение данных из Bunch.cs____________________");
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
                default:
                    Console.WriteLine("Неверный метод, попробуйте ещё раз!");
                    goto select;
            }
        }

        static int First()              // метод 1
        {
            int a = 12;
            return a;                   // return - возвращает значение и выходит из метода, всё что будет ниже не сработает!
        }

        static string Method3() => ("Сокращенная запись метода");

        public void All()
        {
            Console.WriteLine(First());     // краткая запись вызова из метода
            Console.ReadKey();              // чтобы консоль не сразу закрывалась
        }
    }
}