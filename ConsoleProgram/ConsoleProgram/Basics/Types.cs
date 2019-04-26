using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 23. Типы значений и ссылочные типы, стек(stek), куча(heap)

    /* Система типов в C#:
     * 1. Типы значений (Value types):
     * Простые типы
     *  - Целочисленный со знаком: sbyte, short, int,long
     *  - Целочисленный без знака: byte, ushort, uint,ulong
     *  - Символы Юникода: char
     *  - IEEE-представление с плавающей запятой: float, double
     *  - Десятичный с повышенной точностью: decimal
     *  - Логическое значение: bool
     *  Типы перечисления
     *  - Пользовательские типы в формате enum E {...}
     *  Типы структур
     *  - Пользовательские типы в формате struct S {...}
     *  Типы значений, допускающие значение NULL
     *  - Расширения других типов значений, допускающие значение null
     *  
     *  2. Ссылочные типы (Reference types)
     *  Типы классов
     *  - Исходный базовым классом для всех типов: object
     *  - Строки Юникода: string
     *  - Пользовательские типы в формате class C {...}
     *  Типы интерфейса
     *  - Пользовательские типы в формате interface I {...}
     *  Типы массивов
     *  - Одно- и многомерные, например, int[] и int[,]
     *  Тип делегатов
     *  - Пользовательские типы в формате delegate int D(...)
     */
    class Types
    {
        /* Типы значений размещаются в стеке. Стек - список эл-ов, организованный
         * по принципу LIFO (Last In First Out), первый пришёл, последний вышел
        */
        // Фрейм №1 метода Action в стеке
        public void Action()
        {
            Calc(3);
            // структура State - ее данные в стеке
            State state1 = new State();
            // класс Country - его данные в куче, ссылка на адре в стеке
            Country country1 = new Country();

            new TypeValues().CopyValues();
        }

        // Фрейм №2 метода Calc в стеке
        static void Calc(int c) // №1
        {
            int a = 1;  // №2
            int b = 2;  // №3
            int d = a + b + c;  // №4
        }

        // Фрейм №3 метода Calc2 в стеке
        static void Calc2(int c)    // №1
        {
            object a = 1;   // №2, ссылка на 'a' в куче
            int b = 2;      // №3
            int d = b + c;  // №4
        }
    }
    // в стеке
    struct State
    {
        public int x;   // №1
        public int y;   // №2
        public Country country;    // №3 ссылка в стеке!
    }
    // в куче
    class Country
    {
        public int x;   // №1 в куче
        public int y;   // №2 в куче
    }

    // копирование значений значимого и ссылочного типа
    class TypeValues
    {
        public void CopyValues()
        {
            // Структура State (значимый тип)
            State state1 = new State();
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            // state1 получает копию state2
            state1 = state2;
            // state1.x = 1, т.к. по ссылке
            state2.x = 3;
            Console.WriteLine(state1.x);    // 1
            Console.WriteLine(state2.x);    // 3

            // Класс Country (ссылочный тип)
            Country country1 = new Country();
            Country country2 = new Country();
            country2.x = 1;
            country2.y = 2;
            // country1 получает ссылку на объекты country2
            country1 = country2;
            // state1.x = 3, т.к. обе ссылке указывают на один объект в куче
            country2.x = 3;
            Console.WriteLine(country1.x);  // 3
            Console.WriteLine(country2.x);  // 3

            // Ссылочные типы внутри типов значений
            // Структура State (значимый тип)
            State state3 = new State();
            State state4 = new State();
            // state 4 в стеке получила ссылка на объект country.x в куче
            state4.country = new Country();
            state4.country.x = 6;
            // присвоение двух структур
            state3 = state4;
            state4.country.x = 10;
            Console.WriteLine(state4.country.x);  // 10
            Console.WriteLine(state3.country.x);  // 10
            /*  Стек                    Куча
             * state4.country   --->    country.x
             * state4.y           /     country.y
             * state4.x          /
             * state3.country  -/
             * state3.y
             * state3.x
             */
        }
    }
}
