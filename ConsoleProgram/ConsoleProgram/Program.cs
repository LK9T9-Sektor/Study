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
        // точка входа, метод Main, static - статистический, void - ничего не возвращает
        static void Main(string[] args)
        // блок операторов {}
        {
            // заголовок программы
            Console.Title = "Обучение C#";
            // вызываем Меню Выбора
            new Program().SelectionMenu();

            // Чтобы консоль не сразу закрывалась, в данном случае уже не нужно
            Console.ReadKey();
        }

        private void SelectionMenu()
        {
            string line = "__________________________";
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
                "24. Объекты классов как параметры методов\n" +
                "25. Модификаторы доступа\n" +
                "26. Свойства { get; set; } и инкапсуляция\n" +
                "27. Перегрузка методов\n" +
                "28. Статические члены и модификатор static\n" +
                "29. Константы и поля для чтения (readonly)\n" +
                "30. Перегрузка операторов\n" +
                "31. Оператор null-объединения (??), условный null (?)\n" +
                "32. Индексаторы\n" +
                "33. Наследование, base\n" +
                "34. Преобразование типов (объектов классов). Upcasting, downcasting. as, is\n" +
                "35. Перегрузка операций преобразования типов.  explicit, implicit\n" +
                "36. Полиморфизм. virtual, override sealed\n");
            select:
            Console.WriteLine("_____________________________________________________________________");
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
                    Console.WriteLine($"{ line } Bunch { line }");
                    //Bunch bunch = new Bunch();
                    Console.WriteLine(new Bunch().OfThings());
                    goto select;
                case "2":
                    Console.WriteLine($"{ line } Implicit { line }");
                    Console.WriteLine(new Implicit().Variable());
                    goto select;
                case "3":
                    Console.WriteLine($"{ line } Overflow { line }");
                    Overflow overflow = new Overflow();
                    Console.WriteLine(overflow.Action());
                    //int meth_2 = Overflow();
                    //Console.WriteLine($"Из метода №2: {Overflow()}");
                    //Console.WriteLine(meth_2);
                    goto select;
                case "4":
                    Console.WriteLine($"{ line } Convertator { line }");
                    // создаём экземпляр нашего класса
                    Convertator convertator = new Convertator();
                    // вызываем метод экземпляра класса и получаем ответ ()
                    Console.WriteLine(new Convertator().Numbers());

                    // Далее не обязательно
                    //int z1;                                  // переменная для получения результата
                    //z1 = Convertator.Numbers();               // переданное значение присваиваем в переменнуюю z
                    //Console.WriteLine(z1.GetType());         // получение типа переменной
                    goto select;
                case "5":
                    Console.WriteLine($"{ line } BitHandling { line }");
                    Console.WriteLine(new BitHandling().Action());
                    goto select;
                case "6":
                    Console.WriteLine($"{ line } Assignment { line }");
                    Console.WriteLine(new Assignment().Action());
                    goto select;
                case "7":
                    Console.WriteLine($"{ line } Conversion { line }");
                    Console.WriteLine(new Conversion().Action());
                    goto select;
                case "8":
                    Console.WriteLine($"{ line } Conditional { line }");
                    new Conditional().Action();
                    goto select;
                case "9":
                    Console.WriteLine($"{ line } ConditionalConstructions { line }");
                    new ConditionalConstructions().Action();
                    goto select;
                case "10":
                    Console.WriteLine($"{ line } Cycles { line }");
                    Console.WriteLine(new Cycles().Action());
                    goto select;
                case "11":
                    Console.WriteLine($"{ line } Array { line }");
                    Console.WriteLine(new Array().Action());
                    goto select;
                case "12":
                    Console.WriteLine($"{ line } Method12 { line }");
                    new Methods().Method12();
                    //Console.WriteLine(new Array().Action());
                    goto select;
                case "13":
                    Console.WriteLine($"{ line } Method13 { line }");
                    new Methods().Method13();
                    goto select;
                case "14":
                    Console.WriteLine($"{ line } Method14 { line }");
                    new Methods().Method14();
                    goto select;
                case "15":
                    Console.WriteLine($"{ line } Method15 { line }");
                    new Methods().Method15();
                    goto select;
                case "16":
                    Console.WriteLine($"{ line } Method16 { line }");
                    new Methods().Method16();
                    goto select;
                case "17":
                    Console.WriteLine($"{ line } Context { line }");
                    new Context().Show();
                    goto select;
                case "18":
                    Console.WriteLine($"{ line } Recursion { line }");
                    new Recursion().Action();
                    goto select;
                case "19":
                    Console.WriteLine($"{ line } Enumerable { line }");
                    new Enumerable().Action();
                    goto select;
                case "20":
                    Console.WriteLine($"{ line } Tuples { line }");
                    new Tuples().Action();
                    goto select;
                case "21":
                    Console.WriteLine($"{ line } Oop_classes_objects { line }");
                    new Oop_classes_objects().Action();
                    goto select;
                case "22":
                    Console.WriteLine($"{ line } Structures { line }");
                    new Structures().Action();
                    goto select;
                case "23":
                    Console.WriteLine($"{ line } Types { line }");
                    new Types().Action();
                    goto select;
                case "24":
                    Console.WriteLine($"{ line } ObjectsLikeParameters { line }");
                    new ObjectsLikeParameters().Action();
                    goto select;
                case "25":
                    Console.WriteLine($"{ line } AccessModifiers { line }");
                    new AccessModifiers().Action();
                    goto select;
                case "26":
                    Console.WriteLine($"{ line } Properties_encapsulation { line }");
                    new Properties_encapsulation().Action();
                    goto select;
                case "27":
                    Console.WriteLine($"{ line } Method_overloading { line }");
                    new Method_overloading().Action();
                    goto select;
                case "28":
                    Console.WriteLine($"{ line } Static_members_modifier { line }");
                    new Static_members_modifier().Action();
                    goto select;
                case "29":
                    Console.WriteLine($"{ line } Const_readonly { line }");
                    new Const_readonly().Action();
                    goto select;
                case "30":
                    Console.WriteLine($"{ line } OperatorsOverload { line }");
                    new OperatorsOverload().Action();
                    goto select;
                case "31":
                    Console.WriteLine($"{ line } NullOperator { line }");
                    new NullOperator().Action();
                    goto select;
                case "32":
                    Console.WriteLine($"{ line } Indexers { line }");
                    new Indexers().Action();
                    goto select;
                case "33":
                    Console.WriteLine($"{ line } Inheritance { line }");
                    new Inheritance().Action();
                    goto select;
                case "34":
                    Console.WriteLine($"{ line } TypeConversion { line }");
                    new TypeConversion().Action();
                    goto select;
                case "35":
                    Console.WriteLine($"{ line } OverloadingTypeConversion { line }");
                    new OverloadingTypeConversion().Action();
                    goto select;
                case "36":
                    Console.WriteLine($"{ line } Polymorphism_VirtualMethods { line }");
                    new Polymorphism_VirtualMethods().Action();
                    goto select;
                default:
                    Console.WriteLine("Неверный метод, попробуйте ещё раз!");
                    goto select;
            }
        }
    }
}