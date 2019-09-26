using System;

namespace ConsoleProgram.ExceptionHandling
{
    // 44. Catch. Фильтры исключения When
    class ExceptionsFilters
    {
        public static void Action()
        {
            MathDivide();
            MathDivideSecond();
        }
        static void MathDivide()
        {
            try
            {
                Console.Write("Делим int число 30 на: ");
                int DivideNumber = Convert.ToInt32(Console.ReadLine());
                var z = 30 / DivideNumber;
                Console.WriteLine(z);
            }
            // Обрабатывается только ошибка деления на нуль
            // Остальные ошибки будут пропущены и программа упадёт
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Возникло исключение {ex.Message}");
            }
        }
        // When
        static void MathDivideSecond()
        {
            Console.Write("Введите число A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int result = a / b;
                Console.WriteLine(result);
            }
            // Обработка исключения в блоке catch производится только в том случае,
            // если условие в выражении when истинно. 
            catch (DivideByZeroException) when (a == 0 && b == 0)
            {
                Console.WriteLine("A и B не должны быть равны 0");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
