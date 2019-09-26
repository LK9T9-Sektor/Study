// namespace, пространства имен, из библиотек находящихся по адресу: C:\Windows\assembly
using System;

// Пространство имен ConsoleProgram
namespace ConsoleProgram
{
    // Класс Program в namespace ConsoleProgram (ConsoleProgram.Program)
    class Program
    {
        // Точка входа, метод Main, static - статический, void - ничего не возвращает
        static void Main(string[] args)
        // Блок операторов {}
        {
            // Заголовок программы
            Console.Title = "Обучение C#";

            // Вызываем Меню Выбора
            SelectionMenu.ChooseChapter();

            // Чтобы консоль не сразу закрывалась, в данном случае уже не нужно
            Console.ReadKey();
        }
    }
}