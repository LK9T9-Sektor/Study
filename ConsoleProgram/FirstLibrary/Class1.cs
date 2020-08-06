using System;

namespace FirstLibrary
{
    // Классы определяемые в пространстве имён могут быть только public или internal
    public class Users
    {
        public string City;
        protected int age;  // доступен во всём проекте для текущего и наследуемых классов
        protected string name;
        private int _salary; // не будет доступа для классов наследников
        internal int _experience; // доступен только внутри данного проекта

        // вложенный класс может быть с другими модификаторами доступа
        private class Admin
        {
            private string login;
            private int password;
        }

        public void DisplayAllInfo()
        {
            Console.WriteLine($"Город: {City}, возраст: {age}, имя: {name}, зарплата: {_salary}, " +
                $"опыт: {_experience}");
        }
    }
}
