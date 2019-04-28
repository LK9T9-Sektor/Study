using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 37. Сокрытие (new)
    class Hiding
    {
        public void Action()
        {
            Hiding_Parent den = new Hiding_Parent("Denis", "Smirnov");
            den.Display();

            Hiding_Heritor serg = new Hiding_Heritor("Sergei", "Ivanov", "DNS");
            serg.Display();

            SecondHidingParent shp = new SecondHidingParent();
            shp.name = "Колян";
            Console.WriteLine(shp.name);

            Second_Heritor sh = new Second_Heritor();
            sh.name = shp.name;
            Console.WriteLine(sh.Name);

            Console.WriteLine("const до сокрытия: "+ ExampleHidingConstVar.b);
            Console.WriteLine("const после сокрытия: " + ExampleHidingDerived.b);
        }
    }
    class Hiding_Parent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected int Age;
        public int age
        {
            get { return age; }
            set { age = value; }
        }

        public Hiding_Parent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    // Сокрытие метода
    class Hiding_Heritor : Hiding_Parent
    {               
        public string Company { get; set; }
        public Hiding_Heritor(string firstName, string lastName, string company)
                : base(firstName, lastName)
        {
            Company = company;
        }
        // Сокрытие реализации метода из базового класса
        public new void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
        }
    }

    // Сокрытие свойства
    class SecondHidingParent
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Second_Heritor : SecondHidingParent
    {
        public new string Name
        {
            get { return "Имя: " + base.Name; }
            set { name = value; }
        }
    }

    // Сокрытие переменных и констант
    class ExampleHidingConstVar
    {
        public readonly int a = 100;
        public const int b = 17;
    }
    class ExampleHidingDerived : ExampleHidingConstVar
    {
        public new int a = 30;
        public new const int b = 33;
    }
}
