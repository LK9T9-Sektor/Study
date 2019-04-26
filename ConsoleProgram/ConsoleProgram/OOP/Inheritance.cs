using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 33. Наследование, base
    // Derived - производный
    class Inheritance
    {
        public void Action()
        {
            //Aircraft m = new Aircraft { Type = "Airplane" };
            Aircraft a = new Aircraft ("Airplane");
            a.DisplayType();
            //Aircraft h = new Airplane { Type = "Propeller aircraft"};
            //m.DisplayType();
            Airplane airplane = new Airplane("Propeller aircraft", "Cessna");
            airplane.DisplayType();
            airplane.DisplayCompany();
        }
    }
    class Aircraft
    {   
        /*
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public void DisplayType()
        {
            Console.WriteLine(Type);
        }
        */
        // Конструктор        
        public string Type { get; set; }
        public Aircraft(string type)
        {
            Type = type;
        }

        public void DisplayType()
        {
            Console.WriteLine(Type);
        }        
    }
    // Наследуются свойства, методы, поля, но не конструкторы базового класса
    class Airplane: Aircraft
    {
        public void DisplayCompany()
        {
            // Ошибка, т.к. private и доступ есть только у класса-владельца
            //Console.WriteLine(_type);
            Console.WriteLine(_company);
        }

        // Кючевое слово base
        private string _company;
        public string Company { get { return _company; } set { _company = value; } }
        public Airplane(string type, string _company)
            : base(type)    // передаём на установку в конструктор базового класса
        {
            Company = _company;
        }
    }
    // Не поддерживается множественное наследование
    // От seales class'а нельзя наследоваться
    sealed class Boss
    {
    }

    // Конструкторы в производных классах
    // Конструктор не передаётся производному классу при наследовании
    // Если не определен конструктор по умолчанию, тогда необходимо вызывать конструктор
    // по параметрам с помощью base (как выше)
    class ExampleParent
    {
        public string FirstName;

        // Конструктор по умолчанию
        public ExampleParent()
        {
            FirstName = "Vasya";
            Console.WriteLine("Вызов конструктора без параметров");
        }
    }
    class ExampleDerived : ExampleParent
    {
        public string Color;
        public ExampleDerived(string color)
        {
            Color = color;
        }
    }
}
