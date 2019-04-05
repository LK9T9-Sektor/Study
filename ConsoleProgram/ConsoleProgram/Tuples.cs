using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    /* кортежи комбинируют объекты различных типов
    * p.s. для работы кортежей, необходимо установить "System.ValueTuple -Version 4.5.0" через NuGet Package Manager
    * p.s.s кортежи не поддерживают некоторые ООП, связанные с наследованием!
    */
    class Tuples
    {
        public void Action()
        {
            // неявная типизация кортежа
            var myTuple = (2, 3);
            Console.WriteLine($"Вывод значений кортежа по порядковым номерам \nItem1 = {myTuple.Item1} " +
                $"\nItem2 = {myTuple.Item2}");
            
            myTuple.Item1 *= 2;
            Console.WriteLine($"Вывод для Item1 после умножения на 2: {myTuple.Item1}");

            // явная типизация кортежа
            (int, int, double) mySecondTuple = (4, 5, 5.8);
            Console.WriteLine($"Вывод с явной типизацией \nItem1 = {mySecondTuple.Item1} " +
                $"\nItem2 = {mySecondTuple.Item2}\nItem3 = {mySecondTuple.Item3}");

            // свои названия для элементов кортежа
            var myThirdTuple = (name:"Andrey", age:28);
            Console.WriteLine($"Привет {myThirdTuple.name}, {myThirdTuple.age}");
            // вывод всех значений кортежа
            Console.WriteLine($"{myThirdTuple}");
            // вывод типов значений кортежа
            Console.WriteLine($"{myThirdTuple.GetType()}");
            
            // определение собственных переменных для элементов кортежа
            var (name, age) = ("C#", 7.3);
            Console.WriteLine($"{name}, {age}");

            // вывод нескольких значений кортежа в GetValue()
            var tupleValue = GetValue();
            Console.WriteLine(tupleValue.Item1);
            Console.WriteLine(tupleValue.Item2);

            // передача параметров кортежа в GetValue2()
            var myFourthTuple = GetValue2(("Кортеж", 4), 10);
            Console.WriteLine(myFourthTuple.Item1);
            Console.WriteLine(myFourthTuple.Item2);

            // передача кортеж-массива в GetValue3(), получение кол-ва эл-ов и их суммы
            var myFifthTuple = GetValues3(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine($"Кол-во эл-ов массива: {myFifthTuple.count}");
            Console.WriteLine($"Сумма эл-ов массива: {myFifthTuple.sum}");
        }

        // возвращение методом нескольких значений
        static (int, int) GetValue()
        {
            int result = 1;
            int result2 = 3;
            return (result, result2);
        }

        // передача кортежа в качестве параметра
        static (string, int) GetValue2((string, int) tuple, int x)
        {
            var result = (name: tuple.Item1 + " !", age: tuple.Item2 + x);
            return result;
        }

        // возвращаем кол-во и сумму эл-ов кортежа-массива
        static (int sum, int count) GetValues3(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }
    }
}
