using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    // Классы определяемые в пространстве имён могут быть только public или internal
    public class Users
    {
        public string city;
        protected int age;  // доступен во всём проекте для текущего и наследуемых классов
        protected string name;
        private int salary; // не будет доступа для классов наследников
        internal int experience; // доступен только внутри данного проекта

        // вложенный класс может быть с другими модификаторами доступа
        private class Admin
        {
            private string login;
            private int password;
        }

        public void DisplayAllInfo()
        {
            Console.WriteLine($"Город: {city}, возраст: {age}, имя: {name}, зарплата: {salary}, " +
                $"опыт: {experience}");
        }
    }
}
