using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 38. Абстрактные классы и члены классов(abstract)
    class Abstract
    {
        public void Action()
        {
            // Нельзя создать объект абстрактного класса, используя конструктор
            //Sportsmen sportsmen = new Sportsmen("Luke");

            Boxer boxer = new Boxer("Mike", "Tyson", "Puncher");
            Sprinter sprinter = new Sprinter("Bolt", "Usain", 100);
            boxer.Display();
            sprinter.Display();

            // Вызов абстрактных методов
            boxer.DisplayInfo();
            sprinter.DisplayInfo();

            // Абстрактный класс фигуры. Прямоугольник, периметр и площадь
            Console.WriteLine("\nПериметр и площадь прямоугольника\n");
            Console.Write("Введите ширину: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину: ");
            double height = Convert.ToDouble(Console.ReadLine());

            AbsRectangle per = new AbsRectangle(width, height);
            Console.WriteLine("Периметр = " + per.Perimeter());
            Console.WriteLine("Площадь = " + per.Area());
        }
    }
    // Абстрактными члены класса: методы, свойства, индексаторы, события
    abstract class Sportsmen
    {
        public string Name { get; set; }

        // Абстрактные свойства
        public abstract string LastName { get; set; }

        public Sportsmen(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }

        // Абстрактный метод
        public abstract void DisplayInfo();
    }

    class Boxer : Sportsmen
    {
        public string Style { get; set; }

        // Реализация абстрактного свойства
        private string lastName;
        public override string LastName
        {
            get { return " " + lastName; }
            set { lastName = value; }
        }

        public Boxer(string name, string lastName, string style)
            : base(name)
        {
            LastName = lastName;
            Style = style;
        }
        // Реализация абстрактного метода
        public override void DisplayInfo()
        {
            Console.WriteLine(Name + LastName + ", стиль: " + Style);
        }
    }

    class Sprinter : Sportsmen
    {
        public int Distance { get; set; }

        // Реализация абстрактного свойства
        private string lastName;
        public override string LastName
        {
            get { return " " + lastName; }
            set { lastName = value; }
        }

        public Sprinter(string name, string lastName, int distance)
            : base(name)
        {
            LastName = lastName;
            Distance = distance;
        }
        // Реализация абстрактного метода
        public override void DisplayInfo()
        {
            Console.WriteLine(Name + LastName + ", дистанция: " + Distance + " метров");
        }
    }

    // Классический пример абстрактного класса: система геометрических фигур
    abstract class AbsFigure
    {
        // Абстрактный метод для получения периметра
        public abstract double Perimeter();
        // Абстрактный метод для получения площади
        public abstract double Area();
    }
    // Производный класс прямоугольника
    class AbsRectangle : AbsFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public AbsRectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        // Переопределение получения периметра
        public override double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        // Переопределение получения площади
        public override double Area()
        {
            return Width * Height;
        }
    }
}
