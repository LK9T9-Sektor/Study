using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 34. Преобразование типов (объектов классов). Upcasting, downcasting. as, is
    class TypeConversion
    {
        public void Action()
        {
            // Upcasting
            // Производные типы (классы) представляют собой базовый тип, т.к. внизу иерархии
            // TC_Emplyee и TC_Client
            TC_Employee employee = new TC_Employee("Den", "Yandex");
            // person присваивается ссылка на объект TC_Employee
            // Для сохранения ссылки на объект одного класса в переменную другого
            // выполняется преобразование типов от TC_Employee к TC_Person
            // Т.к. TC_Empl.. наследует от TC_Person, то происходит неявное восходящее преобразование
            TC_Person person = employee; // преобразование от TC_Employee к TC_Person            
            // employee и person указывают на один и тот же объект в памяти (в Heap)
            // Но, person доступна часть с функционалом Person
            Console.WriteLine(person.Name);
            
            // Upcasting от TC_Employee к object
            object person1 = new TC_Employee("Mad", "Oracle");
            // Upcasting от TC_Client к object
            object person2 = new TC_Client("Bill", "Microsoft");
            // Upcasting от TC_Person к object
            object person3 = new TC_Person("Sam");

            // Downcasting (от базового к производному)
            TC_Employee employee1 = new TC_Employee("Max", "Unity");
            // преобр. от TC_Employye к TC_Person
            TC_Person person4 = employee1;
            // необходимо применить явное преобразование
            // преобр. от TC_Person к TC_Employye
            TC_Employee employee2 = (TC_Employee)person;

            object obj = new TC_Employee("Mad", "Oracle");
            TC_Employee emp = (TC_Employee)obj;

            TC_Person pers = new TC_Client("Sam", "Ubisoft");
            // от TC_Person к TC_CLient
            TC_Client client = (TC_Client)pers;

            object obj1 = new TC_Employee("Mad", "Oracle");
            // Преобразование для вызова метода
            ((TC_Person)obj1).Display();

            // Преобразование к типу TC_Employee для получения свойства Company
            string comp = ((TC_Employee)obj1).Company;

            KeyWordConversion();
            CatchingException();
            CheckingConversionAllowing();
        }
        // Попытка преобразованися с помощью as
        public void KeyWordConversion()
        {
            TC_Person person = new TC_Person("Ben");
            TC_Employee emp = person as TC_Employee;
            if (emp == null)
            {
                Console.WriteLine("Преобразование прошло неудачно!");
            }
            else
            {
                Console.WriteLine(emp.Company);
            }
        }
        // Ловим InvalidCastException
        public void CatchingException()
        {
            TC_Person person = new TC_Person("Lilly");
            try
            {
                TC_Employee emp = (TC_Employee)person;
                Console.WriteLine(emp.Company);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // Проверка допустимости преобр. с помощью is
        public void CheckingConversionAllowing()
        {
            TC_Person person = new TC_Person("Anna");
            if(person is TC_Employee)
            {
                TC_Employee emp = (TC_Employee)person;
                Console.WriteLine(emp.Company);
            }
            else
            {
                Console.WriteLine("Преобразование не доступно!");
            }
        }
    }
    // Цепь наследования: Object(неявно)-> TC_Person -> TC_Emplyee -> TC_Client
    class TC_Person
    {
        public string Name { get; set; }
        public TC_Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }
    class TC_Employee : TC_Person
    {
        public string Company { get; set; }
        public TC_Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }
    class TC_Client : TC_Person
    {
        public string Bank { get; set; }
        public TC_Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }
}
