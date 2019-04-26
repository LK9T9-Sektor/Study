using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 30. Перегрузка операторов
    class OperatorsOverload
    {
        public void Action()
        {
            OverCounter c1 = new OverCounter { Value = 33 };
            OverCounter c2 = new OverCounter { Value = 77 };

            bool result = c1 > c2;
            Console.WriteLine(result);
            OverCounter c3 = c1 + c2;
            Console.WriteLine(c3.Value);

            int d = c1 + 11; // 44
            Console.WriteLine(d);

            Console.WriteLine(c1.Value);  // 33
            Console.WriteLine(++c1.Value);  // 34

            // false
            OverCounter overCounter = new OverCounter() { Value = 0 };
            if (overCounter)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
    class OverCounter
    {
        public int Value { get; set; }

        // Для перегрузки операторов метод должен быть public static, т.к. используется
        // для всех объектов класса
        public static OverCounter operator +(OverCounter c1, OverCounter c2)
        {
            return new OverCounter { Value = c1.Value + c2.Value };
        }
        // переопределили операцию >
        public static bool operator >(OverCounter c1, OverCounter c2)
        {
            return c1.Value > c2.Value;
        }
        // переопределили операцию <
        public static bool operator <(OverCounter c1, OverCounter c2)
        {
            return c1.Value < c2.Value;
        }

        // Ещё перегрузка оператора по прошлому методу  
        public static int operator +(OverCounter c1, int val)
        {
            return c1.Value + val;
        }
        // Инкремент, примет только один аргумент, т.к. унарный
        public static OverCounter operator ++(OverCounter c1)
        {
             return new OverCounter { Value = c1.Value};
        }

        // Переопределение true, false
        public static bool operator true(OverCounter c1)
        {
            return c1.Value != 0;
        }
        public static bool operator false(OverCounter c1)
        {
            return c1.Value == 0;
        }
    }
    // Не все операторы можно перегрузить, msdn в помощь
}
