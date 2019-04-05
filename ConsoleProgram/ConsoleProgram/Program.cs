//namespace, пространства имен, из библиотек находящихся по адресу: C:\Windows\assembly
using System;                               
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//пространство имен ConsoleProgram
namespace ConsoleProgram                    
{
    // класс Program в namespace ConsoleProgram (ConsoleProgram.Program)
    class Program                           
    {
        // точка входа, метод Main, static - статистический, void - ничего не возвращает (метод №0)
        static void Main(string[] args)
        // блок операторов {}
        {
            // заголовок программы
            Console.Title = "Обучение C#";
        // метка start:
        start:                              
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
                "16. Ключевое слово params. Массив параметров\n" +
                "17. Область видимости (контекст) переменных\n" +
                "18. Рекурсивные функции (Факториал, число Фибоначи)\n" +
                "19. Перечисления enum\n" +
                "20. Кортежи\n" +
                "21. ООП: классы, объекты, this, конструкторы, инициализаторы объектов\n" +
                "22. Структуры\n" +
                "23. Типы значений и ссылочные типы, стек(stek), куча(heap)\n" +
                "24. Объекты классов как параметры методов\n");
        select:
            Console.WriteLine("_________________________________________________________________");
            Console.Write("Выход из программы: 0. Отображения списка методов: ?\nВведите номер метода: ");
            //int selection = Convert.ToInt32(Console.ReadLine());
            string selection = Console.ReadLine();
            // очистка консоли
            Console.Clear();
            switch (selection)
            {
                case "?":
                    // переход к метке start:
                    goto start;                  
                case "0":
                    // закрытие программы и передача кода 0
                    Environment.Exit(0);     
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
                    new Methods().Method12();
                    //Console.WriteLine(new Array().Action());
                    goto select;
                case "13":
                    Console.WriteLine("_____________________Внутренний метод 13_________________________");
                    new Methods().Method13();
                    goto select;
                case "14":
                    Console.WriteLine("_____________________Внутренний метод 14_________________________");
                    new Methods().Method14();
                    goto select;
                case "15":
                    Console.WriteLine("_____________________Внутренний метод 15_________________________");
                    new Methods().Method15();
                    goto select;
                case "16":
                    Console.WriteLine("_____________________Внутренний метод 16_________________________");
                    new Methods().Method16();
                    goto select;
                case "17":
                    Console.WriteLine("_______________Получение данных из Context.cs_____________________");
                    new Context().Show();
                    goto select;
                case "18":
                    Console.WriteLine("______________Получение данных из Recursion.cs_____________________");
                    new Recursion().Action();
                    goto select;
                case "19":
                    Console.WriteLine("______________Получение данных из Enumerable.cs____________________");
                    new Enumerable().Action();
                    goto select;
                case "20":
                    Console.WriteLine("______________Получение данных из Tuples.cs_________________________");
                    new Tuples().Action();
                    goto select;
                case "21":
                    Console.WriteLine("______________Получение данных из Oop_classes_objects.cs_____________");
                    new Oop_classes_objects().Action();
                    goto select;
                case "22":
                    Console.WriteLine("______________Получение данных из Structures.cs_______________________");
                    new Structures().Action();
                    goto select;
                case "23":
                    Console.WriteLine("______________Получение данных из Types.cs____________________________");
                    new Types().Action();
                    goto select;
                default:
                    Console.WriteLine("Неверный метод, попробуйте ещё раз!");
                    goto select;
            }

        }
        
        public void All()
        {
            Console.WriteLine();
            Console.ReadKey();                  // чтобы консоль не сразу закрывалась
        }
    }
}