using System;

namespace ConsoleProgram.OOP
{
    // 42. Наследование обобщенный типов
    class GenericsInheritance
    {
        public static void Action()
        {
            // 1. Типизированный наследник
            BaseAcc<string> acc1 = new BaseAcc<string>("123");
            BaseAcc<int> acc2 = new UniversalAcc<int>(321);
            UniversalAcc<string> acc3 = new UniversalAcc<string>("322");
            Console.WriteLine(acc1.Id);
            Console.WriteLine(acc2.Id);
            Console.WriteLine(acc3.Id);

            // 2. Явно определенный наследник
            StringAcc acc4 = new StringAcc("3228");
            // Так не выйдет, т.к. типы различны
            //BaseAcc<int> acc5 = new StringAcc("333");
            BaseAcc<string> acc5 = new StringAcc("333");
            Console.WriteLine(acc4.Id);
            Console.WriteLine(acc5.Id);

            // 3. Явно определен базовый в наследнике
            IntAcc<string> acc6 = new IntAcc<string>(555) { Code = "3" };
            BaseAcc<int> acc7 = new IntAcc<double>(08);
            Console.WriteLine(acc6.Id);
            Console.WriteLine(acc6.Id.GetType());
            Console.WriteLine(acc7.Id);
            Console.WriteLine(acc7.Id.GetType());

            // 4. С применением своих параметров
            MixedAcc<string, int> acc8 = new MixedAcc<string, int>("234") { Code = 111};
            BaseAcc<string> acc9 = new MixedAcc<string, int>("99") { Code = 1 };
            Console.WriteLine(acc8.Id);
            Console.WriteLine(acc8.Id.GetType());
            Console.WriteLine(acc9.Id);
            Console.WriteLine(acc9.Id.GetType());
        }
    }
    // Базовый класс
    class BaseAcc<T>
    {
        public T Id { get; private set; }
        public BaseAcc(T _id)
        {
            Id = _id;
        }
    }
    // 1. Создание класса-наследника типизированого тем же типом, что и базовый
    class UniversalAcc<T> : BaseAcc<T>
    {
        public UniversalAcc(T id) : base(id)
        {

        }
    }
    // 2. Создание обычного необобщенного класса-наследника.
    // В этом случае надо явно определить используемый тип
    class StringAcc : BaseAcc<string>
    {
        public StringAcc(string id) : base(id)
        {

        }
    }
    // 3. Типизация производного класса другим типом отличным от
    // универасального параметра <T> в базовом классе.
    // Для базового надо указывать тип
    class IntAcc<T> : BaseAcc<int>
    {
        public T Code { get; set; }
        public IntAcc(int _id) : base(_id)
        {
        }
    }
    // 4. С применением своих параметров
    class MixedAcc<T, K> : BaseAcc<T>
        where K : struct
    {
        public K Code { get; set; }
        public MixedAcc(T _id) : base(_id)
        {
        }
    }
    // 5. Если на уровне базового класса выставлено ограничение, то
    // необходимо и в производных классах определить данные ограничение для <T>
    class RestrictedClass<T> where T : class
    {
        public RestrictedClass()
        {
        }
    }
    // Ограничение T : class необходимо указывать во всех производных классах от базового
    class InherateClass<T> : RestrictedClass<T>
        where T : class
    {
        public InherateClass()
        {
        }
    }
}
