using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 26. Свойства { get; set; } и инкапсуляция
    class Properties_encapsulation
    {
        public void Action()
        {
            Person1 tom = new Person1();
            tom.Name = "Tom";               // set, через value
            tom.Age = 40;
            string Name = tom.Name;         // get
            int Age = tom.Age;
            Console.WriteLine($"{ tom.Name}, {tom.Age}");    // get

            tom.SurName = "Tomkins";
            //Console.WriteLine($"{ tom.SurName}");    // get не установлен, нельзя
            //tom.FullName = "Tom Tomkins"; // set не установлен, нельзя
            Console.WriteLine(tom.FullName);
            tom.Money = 3000;
            Console.WriteLine($"Баланс = {tom.Money} \nДолг = {tom.Debt}");
            //tom.Birth = 1979; // private set недоступен
            Console.WriteLine(tom.Birth);
            //tom.Patronymic = "Tomovich";  // необъявленный set - private
        }
    }
    class Person1
    {
        private string name;
        public string Name
            // Стандартное определение свойства { get; set }
            // Управляет доступом в переменной
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // Свойство могут определять один блок, get или set
        private string surName;
        public string SurName
        {
            set { surName = value; }
        }

        public string FullName
        {
            get { return $"{name} {surName}"; }
        }

        // Пример инкапсуляции
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >=0 && value <99)
                    age = value;
            }
        }

        // Полное определение свойства. Авто-свойство
        public int Money { get; set; }
        // Присвоение значения авто-свойству
        public int Debt { get; set; } = 560;

        // Использование модификаторов доступа
        private int birth = 1900;
        public int Birth
        {
            get { return birth; }
            // Невозможно будет установить дату извне класса
            private set
            {
                birth = value;
            }
        }

        // Можно передать значение через конструктор в классе
        public Person1()
        {
            Birth = 1979;
        }

        // По умолчанию, не объявленное свойство будет - private
        public string Patronymic { get; }

        // Сокращенная запись свойств
        private string empty;
        // Эквивалентно public string Empty {get {return empty;} }
        public string Empty => empty;
    }
}
