using System;

namespace ConsoleProgram.ExceptionHandling
{
    class ExceptionsConstruction
    {
        // 43. Обработка исключений. Конструкция try..catch..finally
        public static void Action()
        {
            try
            {
                Console.Write("Введите число. Делим его на 5: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                new ExceptionsConstruction().SomeMath(Number);
            }
            catch
            {
                Console.WriteLine("Введите число!");
            }

            SquareNumber();
        }
        private void SomeMath(int x)
        {
            try
            {
                int y = 5 / x;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                // Если в блоке try не возникла ошибка, выполняется блок finally
                // Блок finally можно опустить
            }
        }
        // Обработка исключения условной конструкцией
        static void SquareNumber()
        {
            int x;
            Console.Write("Введите число, для возведения в квадрат: ");
            string input = Console.ReadLine();

            // TryParse() возвращает true, если преобразование можно осуществить, и false - если нельзя
            if (Int32.TryParse(input, out x))
            {
                x *= x;
                Console.WriteLine("Квадрат числа: " + x);
            }
            else
            {
                Console.WriteLine("Неверный ввод числа!");
            }
        }
    }
}
