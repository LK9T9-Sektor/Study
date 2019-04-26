using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 36. Полиморфизм. virtual, override sealed
    class Polymorphism_VirtualMethods
    {
        public void Action()
        {
            Animal animal = new Animal("Зверюшки\n");
            animal.Display();
            Bear bear = new Bear("Медведь", "Белый");
            bear.Display();
            Pantera pantera = new Pantera("Пантера", "джунгли");
            pantera.Display();
            Camel camel = new Camel("Верблюд", "колючки");
            camel.Display();

            Bactrianus bactrianus = new Bactrianus("Двугорбый верблюд", "лук");
            bactrianus.Display();

            Console.WriteLine("\n[С помощью массива]\n");

            // Массив для зверей
            Animal[] animals = new Animal[3];
            // Экземпляры всех зверей
            Bear bear1 = new Bear("Медведь", "Бурый");
            Pantera pantera1 = new Pantera("Пантера", "прыгать");
            Camel camel1 = new Camel("Верблюд", "саксаул");
            // С помощью Upcasting помещаем в массив Animals
            animals[0] = bear1;
            animals[1] = pantera1;
            animals[2] = camel1;

            // С помощью цикла у каждого объекта вызываем метод Display
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Display();
            }

            Carp fish = new Carp();
            Console.Write("\nВведите возраст карпа: ");
            fish.Age = Convert.ToInt32(Console.ReadLine());
            fish.DisplayAge();
        }
    }
    class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        // virtual - спецификатор, даёт возможность переопределения
        // реализации метода в наследумеых классах
        public virtual void Display()
        {
            Console.WriteLine($"{Name}");
        }
    }

    class Bear : Animal
    {
        public string Color { get; set; }
        public Bear(string name, string color)
            : base(name)
        {
            Color = color;
        }
        // override - переопределение
        public override void Display()
        {
            //base.Display();
            Console.WriteLine($"{Color} {Name}");
        }
    }

    class Pantera : Animal
    {
        public string Loves { get; set; }
        public Pantera(string name, string loves)
            : base(name)
        {
            Loves = loves;
        }
        public override void Display()
        {
            Console.WriteLine(Name + " любит " + Loves);
        }
    }

    class Camel : Animal
    {
        public string Food { get; set; }
        public Camel(string name, string food)
            : base(name)
        {
            Food = food;
        }

        // sealed - запрет на переопределение (в паре с override)
        // Запретили всем наследумым классам от Camel, переопределение данного метода
        public override sealed void Display()
        {
            Console.WriteLine(Name + " ест " + Food);
        }
    }
    // Двугорбый верблюд, наследуется от класса Camel
    class Bactrianus : Camel
    {
        public Bactrianus(string name, string food)
            : base(name, food)
        {

        }
        // Не сработает, т.к. override sealed в базовом классе Camel
        /*
        public override void Display()
        {

        }
        */
    }

    // Переопределение свойств
    class Fish
    {
        public virtual int Age { get; set; }
        public void DisplayAge()
        {
            Console.WriteLine(Age);
        }
    }
    class Carp : Fish
    {
        public string Name { get; set; }

        private int age;
        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Карпы столько не живут!");
                }
            }
        }
    }
}