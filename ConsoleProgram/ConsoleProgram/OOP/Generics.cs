using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 40. Универсальные шаблоны(generics)
    class Generics
    {
        public void Action()
        {
            GenAccount<int> acc1 = new GenAccount<int> { Sum = 1000 };
            GenAccount<string> acc2 = new GenAccount<string> { Sum = 2000 };

            // Упаковка не нужна
            acc1.Id = 1;
            acc2.Id = "999";
            // Распоковка не нужна
            int id1 = acc1.Id;
            string id2 = acc2.Id;
            Console.WriteLine(id1);
            Console.WriteLine(id2);
            Console.WriteLine("ID " + acc1.Id + ", сумма = " + acc1.Sum);
            Console.WriteLine("ID " + acc2.Id + ", сумма = " + acc2.Sum);

            GenAccount<int>.session = 322;
            GenAccount<string>.session = "228q";
            Console.WriteLine("Сессия: " + GenAccount<int>.session);
            Console.WriteLine("Сессия: " + GenAccount<string>.session);

            // Использование нескольких унивес. шаблонов. Перевод суммы.
            GenAccount<int> acc3 = new GenAccount<int> { Id = 3, Sum = 3000 };
            GenAccount<int> acc4 = new GenAccount<int> { Id = 4, Sum = 2560 };

            GenTransaction<GenAccount<int>, string> transaction1 = new GenTransaction<GenAccount<int>, string>
            {
                FromAccount = acc3,
                ToAccount = acc4,
                OperationCode = "3228",
                Sum = 500
            };

            // Операция с шаблонным методом
            Console.Write("Введите число x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\tМеняем местами");
            Swap<int>(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            Console.Write("Введите первое слово: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите второе слово: ");
            string s2 = Console.ReadLine();
            Console.WriteLine("\tМеняем местами");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"{s1} {s2}");            
        }
        // Шаблонный метод
        // Меняет местами значения x, y
        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
    // Универсальный параметр <> - буквы внутри могут быть любыми
    class GenAccount<T>
    {
        public T Id { get; set; }
        public int Sum { get; set; }
        // Присвоение значения по умолчанию
        // Ссылочные типы будут null, значимые = 0
        T id = default(T);
        // Статические поля шаблонов
        public static T session;
    }
    // Использование нескольких универсальных шаблонов
    class GenTransaction<S, F>
    {
        public S FromAccount { get; set; }      // со счёта
        public S ToAccount { get; set; }        // на счёт
        public F OperationCode { get; set; }    // код операции
        public int Sum { get; set; }            // сумма перевода
    }
}
