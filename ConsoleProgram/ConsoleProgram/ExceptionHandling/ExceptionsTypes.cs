using System;

namespace ConsoleProgram.ExceptionHandling
{
    // 45. Типы исключений. Класс Exception
    class ExceptionsTypes
    {
        public static void Action()
        {
            DivideByZero();
        }
        static void DivideByZero()
        {
            try
            {
                int x = 3;
                int y = 0;
                int z = x / y;
            }
            catch (Exception ex)
            {
                // InnerException: хранит информацию об исключении, которое послужило причиной текущего исключения.

                // Message: хранит сообщение об исключении, текст ошибки.
                Console.WriteLine($"Исключение: {ex.Message}");
                // Source: хранит имя объекта или сборки, которое вызвало исключение.
                Console.WriteLine($"Сборка: {ex.Source}");
                // StackTrace: возвращает строковое представление стека вызывов, которые привели к возникновению исключения.
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
                // TargetSite: возвращает метод, в котором и было вызвано исключение
                Console.WriteLine($"Метод: {ex.TargetSite}");

                TwoExBlocks();
            }
        }
        // Специализированные типы исключений
        // DivideByZeroException: представляет исключение, которое генерируется при делении на ноль
        // ArgumentOutOfRangeException: генерируется, если значение аргумента находится вне диапазона допустимых значений
        // ArgumentException: генерируется, если в метод для параметра передается некорректное значение
        // IndexOutOfRangeException: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений
        // InvalidCastException: генерируется при попытке произвести недопустимые преобразования типов
        // NullReferenceException: генерируется при попытке обращения к объекту, который равен null (то есть по сути неопределен)
        static void TwoExBlocks()
        {
            try
            {
                int[] numbers = new int[4];
                numbers[7] = 9;     // IndexOutOfRangeException

                int x = 5;
                int y = x / 0;  // DivideByZeroException
                Console.WriteLine($"Результат: {y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");

                ExBlockForAll();

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // Обработка ошибок однотипна. В данном методе отдельно выводятся две ошибки,
        // остальные в отдельном блоке для всех.
        static void ExBlockForAll()
        {
            try
            {
                object obj = "you";
                int num = (int)obj;     // InvalidCastException
                Console.WriteLine($"Результат: {num}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Возникло исключение DivideByZeroException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            }
            // Блок для всех остальных исключений
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
        }
    }
}
