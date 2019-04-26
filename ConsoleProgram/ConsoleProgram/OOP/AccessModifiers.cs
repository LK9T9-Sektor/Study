using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLibrary;

namespace ConsoleProgram
{
    // 25. Модификаторы доступа
    class AccessModifiers
    {
        public void Action()
        {
            Vars vars = new Vars();
            // Не доступны. Доступ в классе в котором определены
            // vars.a = 1;
            // vars.b = 2;
            // vars.c = 3;
            // vars.g = 7;
            vars.d = 4;
            vars.e = 5;
            vars.f = 6;
            // Переменная a скрыта (private), но метод вывода открыт (public)
            vars.Display_a();
            // Также b скрыт, но метод доступен (internal)
            vars.Display_b();
             
            new Manager().WorkWithLibrary();
        }
    }

    class Vars
    {
        int a; // private по умолчанию
        private int b; // поле доступно только из текущего класса
        protected int c; // доступно из текущего класса и производных классов
        internal int d; // доступно в любом месте программы
        protected internal int e; // доступно в любом месте программы и из классов-наследников
        public int f; // доступно в любом месте программы, а также для других программ и сборок
        //protected private int g; // доступно из текущего класса и производных классов, которые определены в том же проекте

        private void Display_f()
        {
            Console.WriteLine($"Переменная f = {f}");
        }

        public void Display_a()
        {
            Console.WriteLine($"Переменная a = {a}");
        }

        internal void Display_b()
        {
            Console.WriteLine($"Переменная b = {b}");
        }

        protected void Display_e()
        {
            Console.WriteLine($"Переменная e = {e}");
        }
    }
    // Наследование класса
    class Manager : Users   // класс Manager по умолчанию internal
    {
        // Класс из библотеки
        public void WorkWithLibrary()
        {            
            Users Alex = new Users();
            Alex.city = "Krasnoyarsk";
            age = 30;
            name = "Alex";
            //salary = 30000; // недоступно, т.к. private
            //experience = 2; // недоступно, т.к. internal
            DisplayAllInfo();
            DisplayInfo();
        }
        public void DisplayInfo()
        {
            Users users = new Users();
            Console.WriteLine($"Город: {city}, возраст: {age}, имя: {name}");
        }
    }
}
