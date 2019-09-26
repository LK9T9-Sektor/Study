using System;
using ConsoleProgram.OOP;
using ConsoleProgram.ExceptionHandling;

namespace ConsoleProgram
{
    class SelectionMenu
    {
        const string ChapterCode = "-";
        const string ExecuteCode = "0";
        const string HelpCode = "?";
        const string line = "__________________________";
        const string HelpText = "Выход из программы: 0. Отображение списка: ? Вернуться на выбор главы: -" +
            "\nВведите номер: ";
        const string ErrorText = "Неверный номер, попробуйте ещё раз!";

        // Метод для завершения работы программы
        public static void ExecuteApp()
        {
            // закрытие программы и передача кода 0
            Environment.Exit(0);
        }

        #region Главы
        public static void ChooseChapter()
        {
        start:
            Console.WriteLine("\t\t\tВыберите главу: \n" +
                "1. Основы программирования\n" +
                "2. Объектно-ориентированное программирование\n" +
                "3. Обработка исключений\n");
        select:
            Console.WriteLine($"{line}{line}{line}");
            Console.Write($"{HelpText}");

            string chapterNumber = Console.ReadLine();
            // Очистка консоли
            Console.Clear();
            switch (chapterNumber)
            {
                case HelpCode:
                    goto start;
                case ExecuteCode:
                    ExecuteApp();
                    break;
                case ChapterCode:
                    ChooseChapter();
                    break;
                case "1":
                    BasicSection();
                    break;
                case "2":
                    OOPSection();
                    break;
                case "3":
                    ExceptionsSection();
                    break;
                default:
                    Console.WriteLine(ErrorText);
                    goto select;
            }
        }
        #endregion

        #region Разделы

        #region Основы программирования
        private static void BasicSection()
        {
        start:
            Console.WriteLine("\t\t\tВыберите раздел: \n" +
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
                "20. Кортежи");
        select:
            Console.WriteLine($"{line}{line}{line}");
            Console.Write($"{HelpText}");

            string selection = Console.ReadLine();

            Console.Clear();
            switch (selection)
            {
                case HelpCode:
                    goto start;
                case ExecuteCode:
                    ExecuteApp();
                    break;
                case ChapterCode:
                    ChooseChapter();
                    break;
                case "1":
                    // Вывод имени класса
                    Console.WriteLine(line + typeof(Bunch).Name.ToString() + line);
                    //Bunch bunch = new Bunch();
                    Console.WriteLine(new Bunch().OfThings());
                    goto select;
                case "2":
                    Console.WriteLine(line + typeof(Implicit).Name.ToString() + line);
                    Console.WriteLine(new Implicit().Variable());
                    goto select;
                case "3":
                    Console.WriteLine(line + typeof(Overflow).Name.ToString() + line);
                    Overflow overflow = new Overflow();
                    Console.WriteLine(overflow.Action());
                    //int meth_2 = Overflow();
                    //Console.WriteLine($"Из метода №2: {Overflow()}");
                    //Console.WriteLine(meth_2);
                    goto select;
                case "4":
                    Console.WriteLine(line + typeof(Convertator).Name.ToString() + line);
                    // Создаём экземпляр (объект) нашего класса
                    Convertator convertator = new Convertator();
                    // Вызываем метод экземпляра (объект) класса и получаем ответ ()
                    Console.WriteLine(new Convertator().Numbers());
                    goto select;
                case "5":
                    Console.WriteLine(line + typeof(BitHandling).Name.ToString() + line);
                    Console.WriteLine(new BitHandling().Action());
                    goto select;
                case "6":
                    Console.WriteLine(line + typeof(Assignment).Name.ToString() + line);
                    Console.WriteLine(new Assignment().Action());
                    goto select;
                case "7":
                    Console.WriteLine(line + typeof(Conversion).Name.ToString() + line);
                    Console.WriteLine(new Conversion().Action());
                    goto select;
                case "8":
                    Console.WriteLine(line + typeof(Conditional).Name.ToString() + line);
                    new Conditional().Action();
                    goto select;
                case "9":
                    Console.WriteLine(line + typeof(ConditionalConstructions).Name.ToString() + line);
                    new ConditionalConstructions().Action();
                    goto select;
                case "10":
                    Console.WriteLine(line + typeof(Cycles).Name.ToString() + line);
                    Console.WriteLine(new Cycles().Action());
                    goto select;
                case "11":
                    Console.WriteLine(line + typeof(Array).Name.ToString() + line);
                    Console.WriteLine(new Array().Action());
                    goto select;
                case "12":
                    Console.WriteLine($"{ line } Method12 { line }");
                    new Methods().Method12();
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
                default:
                    Console.WriteLine(ErrorText);
                    goto select;
            }
        }
        #endregion

        #region Объектно-ориентированное программирование
        private static void OOPSection()
        {
        start:
            Console.WriteLine("\t\t\tВыберите раздел: \n" +
                "1. ООП: классы, объекты, this, конструкторы, инициализаторы объектов\n" +
                "2. Структуры\n" +
                "3. Типы значений и ссылочные типы, стек(stek), куча(heap)\n" +
                "4. Объекты классов как параметры методов\n" +
                "5. Модификаторы доступа\n" +
                "6. Свойства { get; set; } и инкапсуляция\n" +
                "7. Перегрузка методов\n" +
                "8. Статические члены и модификатор static\n" +
                "9. Константы и поля для чтения (readonly)\n" +
                "10. Перегрузка операторов\n" +
                "11. Оператор null-объединения (??), условный null (?)\n" +
                "12. Индексаторы\n" +
                "13. Наследование, base\n" +
                "14. Преобразование типов (объектов классов). Upcasting, downcasting. as, is\n" +
                "15. Перегрузка операций преобразования типов.  explicit, implicit\n" +
                "16. Полиморфизм. virtual, override sealed\n" +
                "17. Сокрытие (new)\n" +
                "18. Абстрактные классы и члены классов (abstract)\n" +
                "19. Класс System.Object и его методы\n" +
                "20. Универсальные шаблоны (Обобщенные типы) (generics)\n" +
                "21. Ограничения обобщений (Generics Constraints)\n" +
                "22. Наследование обобщенный типов");

        select:
            Console.WriteLine($"{line}{line}{line}");
            Console.Write(HelpText);

            string selection = Console.ReadLine();
            Console.Clear();

            switch (selection)
            {
                case HelpCode:
                    goto start;
                case ExecuteCode:
                    ExecuteApp();
                    break;
                case ChapterCode:
                    ChooseChapter();
                    break;
                case "1":
                    Console.WriteLine($"{ line } Oop_classes_objects { line }");
                    new Oop_classes_objects().Action();
                    goto select;
                case "2":
                    Console.WriteLine($"{ line } Structures { line }");
                    new Structures().Action();
                    goto select;
                case "3":
                    Console.WriteLine($"{ line } Types { line }");
                    new Types().Action();
                    goto select;
                case "4":
                    Console.WriteLine($"{ line } ObjectsLikeParameters { line }");
                    new ObjectsLikeParameters().Action();
                    goto select;
                case "5":
                    Console.WriteLine($"{ line } AccessModifiers { line }");
                    new AccessModifiers().Action();
                    goto select;
                case "6":
                    Console.WriteLine($"{ line } Properties_encapsulation { line }");
                    new Properties_encapsulation().Action();
                    goto select;
                case "7":
                    Console.WriteLine($"{ line } Method_overloading { line }");
                    new Method_overloading().Action();
                    goto select;
                case "8":
                    Console.WriteLine($"{ line } Static_members_modifier { line }");
                    new Static_members_modifier().Action();
                    goto select;
                case "9":
                    Console.WriteLine($"{ line } Const_readonly { line }");
                    new Const_readonly().Action();
                    goto select;
                case "10":
                    Console.WriteLine($"{ line } OperatorsOverload { line }");
                    new OperatorsOverload().Action();
                    goto select;
                case "11":
                    Console.WriteLine($"{ line } NullOperator { line }");
                    new NullOperator().Action();
                    goto select;
                case "12":
                    Console.WriteLine($"{ line } Indexers { line }");
                    new Indexers().Action();
                    goto select;
                case "13":
                    Console.WriteLine($"{ line } Inheritance { line }");
                    new Inheritance().Action();
                    goto select;
                case "14":
                    Console.WriteLine($"{ line } TypeConversion { line }");
                    new TypeConversion().Action();
                    goto select;
                case "15":
                    Console.WriteLine($"{ line } OverloadingTypeConversion { line }");
                    new OverloadingTypeConversion().Action();
                    goto select;
                case "16":
                    Console.WriteLine($"{ line } Polymorphism_VirtualMethods { line }");
                    new Polymorphism_VirtualMethods().Action();
                    goto select;
                case "17":
                    Console.WriteLine($"{ line } Hiding { line }");
                    new Hiding().Action();
                    goto select;
                case "18":
                    Console.WriteLine($"{ line } Abstract { line }");
                    new Abstract().Action();
                    goto select;
                case "19":
                    Console.WriteLine($"{ line } ObjectClass { line }");
                    new ObjectClass().Action();
                    goto select;
                case "20":
                    Console.WriteLine($"{ line } Generics { line }");
                    new Generics().Action();
                    goto select;
                case "21":
                    Console.WriteLine($"{ line } GenericsConstraints { line }");
                    new GenericConstraints().Action();
                    goto select;
                case "22":
                    Console.WriteLine($"{ line } GenericsInheritance { line }");
                    GenericsInheritance.Action();
                    goto select;
                default:
                    Console.WriteLine(ErrorText);
                    goto select;
            }
        }
        #endregion

        #region Обработка исключений
        private static void ExceptionsSection()
        {
        start:
            Console.WriteLine("\t\t\tВыберите раздел: \n" +
                "1. Обработка исключений.Конструкция try..catch..finally\n" +
                "2. Catch. Фильтры исключения When\n" +
                "3. Типы исключений. Класс Exception");

        select:
            Console.WriteLine($"{line}{line}{line}");
            Console.Write(HelpText);

            string selection = Console.ReadLine();

            Console.Clear();

            switch (selection)
            {
                case HelpCode:
                    goto start;
                case ExecuteCode:
                    ExecuteApp();
                    break;
                case ChapterCode:
                    ChooseChapter();
                    break;
                case "1":
                    Console.WriteLine(line + typeof(ExceptionsConstruction).Name.ToString() + line);
                    ExceptionsConstruction.Action();
                    goto select;
                case "2":
                    Console.WriteLine(line + typeof(ExceptionsFilters).Name.ToString() + line);
                    ExceptionsFilters.Action();                    
                    goto select;
                case "3":
                    Console.WriteLine(line + typeof(ExceptionsTypes).Name.ToString() + line);
                    ExceptionsTypes.Action();
                    goto select;
                default:
                    Console.WriteLine(ErrorText);
                    goto select;
            }
        }
        #endregion

        #endregion
    }
}
