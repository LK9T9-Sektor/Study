using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // ООП, классы, this, конструкторы, инициализаторы объектов
    class Oop_classes_objects
    {
        public void Action()
        {
            // необходимо указывать на объект класса, необходим конструктор
            // конструктор устанавливает данные для объектов
            // объект имя = new вызов конструктора (значения для параметров конструктора)
            User sam = new User();    // конструктор по имени класса (по умолчанию)
            sam.name = "Sam";
            sam.age = 28;
            sam.Info();

            // передаст в конструктор №4
            User tom = new User("Tom", 23);
            tom.Info();
            // передаст в конструктор №2
            User bob = new User("Bob");
            bob.Info();
            // передаст в конструктор №3
            User max = new User(15);
            max.Info();

            // вводим свои данные, выводит их
            User unk = new User();
            Console.WriteLine("Введите имя: ");
            unk.name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            unk.age = Convert.ToInt32(Console.ReadLine());
            unk.Info();

            // в инициализаторе устанавливаем доступные свойства или глобальные переменные класса
            User Don = new User { name = "Don", age = 30 };
            Don.Info();

            // отдельный вызов для this и т.п.
            SecondUser unk2 = new SecondUser("Leo", 99);
            unk2.SecondInfo();
        }
    }
    // класс как отдельный тип
    // шаблон для создания объектов
    class User
    {
        // поля класса (переменные)
        // public - обще доступно в любой части программы
        public string name;
        public int age;

        // пустой конструктор №1, можно использовать для создания объекта
        public User()
        {

        }

        // конструктор №2 с 1 параметром для имени
        public User(string n)
        {
            name = n;
        }

        // конструктор №3 с 1 параметром для возраста
        public User(int m)
        {
            age = m;
        }

        // конструктор №4 с 2 параметрами для имени и возраста
        public User(string n, int m) : this(n)
        {
            name = n;
            age = m;
        }
               
        // метод выводит данные о пользователе
        public void Info()
        {
            Console.WriteLine($"{name}, {age}");
        }
    }

    // продублировано для понимания: this, сокращение конструктора
    class SecondUser
    {
        public string name;
        public int age;

        // пустой конструктор №1
        public SecondUser()
        {

        }

        // конструктор №2 с именем глобальной переменной
        // this - позволяет ссылаться на функционал класса в самом классе
        public SecondUser(string name)    // name - параметр конструктора
        {
            // this предоставляет ссылку на объект, данного ключевого класса            
            this.name = name;      // this - указывает глобальную переменную name
        }
        
        /* сокращение конструктора №3
        передача данных (имени) в конструктор №2, компилятор понимает по типу и кол-ву параметров в 
        какой конструктор передавать
        */
        public SecondUser(string n, int m) : this(n)
        {
            age = m;
        }

        public void SecondInfo()
        {
            Console.WriteLine($"{name}, {age}");
        }
    }
}