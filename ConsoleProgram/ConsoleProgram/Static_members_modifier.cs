using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 28. Статические члены и модификатор static
    class Static_members_modifier
    {
        public void Action()
        {
            Console.WriteLine("Старт. счёт = " + Scoring.startScore);   // 1000
            Scoring.startScore += 350;
            Console.WriteLine("Счёт +350 = " + Scoring.startScore);   // 1350

            Scoring scoring1 = new Scoring(100.35m);
            Console.WriteLine("Конечный счёт №1 = " + scoring1.totalScore);   // 1450.35

            Scoring scoring2 = new Scoring(2000);
            Console.WriteLine("Конечный счёт №2 = " + scoring2.totalScore);   // 1450.35

            // Для статического поля в куче создается общий участок памяти для
            // всех объектов класса
            new Account(2000, 3).Action();
            new SomeIteration().Action();

            Thing thing1 = new Thing(); // Здесь сработает статический конструктор
            Thing thing2 = new Thing();

            // Вызов метода статического класса
            Console.Write("Введите число: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Квадратный корень числа: {0:#.###}", MyMath.Sqrt(z));
        }
    }
    // Статические поля, методы, свойства относятся ко всему классу и для 
    // обращения к ним необязательно создавать экземпляр класса.
    class Scoring
    {
        public static decimal startScore = 1000;
        public decimal totalScore;

        public Scoring(decimal score)
        {
            totalScore = score + startScore;
        }
    }
    // Статические свойства и методы
    class Account
    {
        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum)
            {
                throw new Exception("Сумма менее 100!");
            }
            Sum = sum;
            Rate = rate;
        }
        private static decimal minSum = 100; // min допустимая сумма для счетов
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; }    // сумма на счете
        public decimal Rate { get; private set; }   // % ставка

        // Подсчет суммы, за период и ставку
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + (result * rate / 100);
            return result;
        }
        public void Action()
        {
            Account.MinSum = 160;
            decimal result = GetSum(1234, 7, 5);
            Console.WriteLine(result);
        }
    }
    // Статические поля
    class Counter
    {
        private static int count = 0;
        public Counter()
        {
            count++;
        }
        public static int DisplayCount()
        {
            return count;
        }
    }
    class SomeIteration
    {
        public void Action()
        {
            Console.Write("Введите кол-во итераций x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            do
            {
                Counter count = new Counter();
                i++;
            }
            while (i < (x + 8) / 3);
            Console.WriteLine(Counter.DisplayCount());
        }
    }
    // Статический конструктор, для инициализации любых данных или для выполнения действия один раз
    // Не должны быть с модификаторами доступа и не принимают параметры
    // Выполняются автоматически, нельзя вызвать вручную, нельзя использовать this
    class Thing
    {
        static Thing()
        {
            Console.WriteLine("Создана первая вещь");
        }
    }
    // Статический класс
    static class MyMath
    {
        public static double Sqrt(double z)
        {
            return Math.Sqrt(z);
        }
    }
}
