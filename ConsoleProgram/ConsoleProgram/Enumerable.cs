using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Enumerable
    {
        enum Days           // int, по умолчанию
        {
            Понедельник,    // 0
            Вторник,        // 1
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье                          
        }
        
        enum Cost           // новое перечисление = новый тип
        {
            Processor = 50,
            VideoCard1 = 150,
            Keyboard = 8,
            Mouse = 15,
            VideoCard2 = VideoCard1,    // Videocard2 = 150
            Power                       // 151, т.к. ^ + 1
        }
        
        enum Operation : byte
        {
            Add,    // +
            Sub,    // -
            Mult,   // *
            Div     // /
        }

        public void Action()
        {
            Days day;
            day = Days.Среда;
            Console.WriteLine(day);         // выводит имя константы, не значение!
            Console.WriteLine((int)day);    // выведет значение константы
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            start:
            Console.Write("Введите операцию (+ , - , * , / ): ");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    ApplyOperation(x, y, Operation.Add);
                    break;
                case "-":
                    ApplyOperation(x, y, Operation.Sub);
                    break;
                case "*":
                    ApplyOperation(x, y, Operation.Mult);
                    break;
                case "/":
                    ApplyOperation(x, y, Operation.Div);
                    break;
                default:
                    Console.WriteLine("Неверная операция");
                    goto start;
            }
        }

        static void ApplyOperation(double x, double y, Operation op)
        {
            double result = 0.0;
            switch(op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Sub:
                    result = x - y;
                    break;
                case Operation.Mult:
                    result = x * y;
                    break;
                case Operation.Div:
                    result = x / y;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
