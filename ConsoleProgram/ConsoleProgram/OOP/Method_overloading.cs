using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 27. Перегрузка методов
    class Method_overloading
    {
        // 4 метода Add, 4 перегрузки, должно быть различие сигнатур
        // Сигнатура Add(int, int)
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Сумма двух чисел: {result}");
        }
        // Сигнатура Add(int, int, int)
        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"Сумма трёх чисел: {result}");
        }
        // Сигнатура Add(int, int, int, int)
        public int Add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            return result;
        }
        // Сигнатура Add(double, double)
        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Сумма двух дробных чисел: {result}");
        }
        // Отличие перегружаемых методов по модификаторам
        public void Increment(int val)
        {
            val++;
            Console.WriteLine($"Инкремент 2: {val}");
        }
        internal void Increment(ref int val)
        {
            val++;
            Console.WriteLine($"Инкремент 3: {val}");
        }

        internal void Action()
        {
            //new Method_overloading().Add(3, 2);
            Add(3, 2);
            Add(3, 2, 1);

            Method_overloading summ = new Method_overloading();
            Console.WriteLine("Сумма четырёх чисел: "+ summ.Add(1, 2, 3, 4));

            int summ4 = Add(3, 4, 5, 6);    // и ещё разочек :)
            Console.WriteLine("Сумма четырёх чисел: " + summ4);

            new Method_overloading().Add(3.1, 2.2);
            new Increment().Action();
        }
    }
    class Increment
    {
        public void Action()
        {
            new Method_overloading().Increment(2);
            new Method_overloading().Increment(val: 3);
        }
    }
}
