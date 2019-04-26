using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 24. Объекты классов как параметры методов
    class ObjectsLikeParameters
    {
        public void Action()
        {
            // Для struct
            Player player1 = new Player { name = "Mike", age = 20 };
            // Отправляем копию объекта на метод
            ChangePlayer(player1);
            // Изменения не произойдут, т.к. работаем с копией значимого типа в стеке
            Console.WriteLine($"{player1.name}, {player1.age}");
            // Передадим по ссылке
            ChangePlayer1(ref player1);
            // Теперь изменения пройдут, т.к. по ссылке
            Console.WriteLine($"{player1.name}, {player1.age}");

            // Для Class
            // person1 хранит ссылку в куче
            Person person1 = new Person { name = "Casey", age = 31 };
            // Отправляем параметр по значению, метод получит копию ссылки
            // Но они ссылаются на один и тот же объет в куче
            ChangePerson(person1);
            Console.WriteLine($"{person1.name}, {person1.age}");
            // Передача по ссылке
            ChangePerson1(ref person1);
            // Также будут изменения
            Console.WriteLine($"{person1.name}, {person1.age}");
        }
        // Метод меняет данные Player
        static void ChangePlayer(Player player)
        {
            player.name = "Ted"; 
            player.age = 32;
        }
        // Передача ссылочного параметра по ссылке
        static void ChangePlayer1(ref Player player)
        {
            player.name = "Ted";
            player.age = 32;
        }
        // Метод меняет данные Person
        static void ChangePerson(Person person)
        {
            person.name = "Ron";
            person.age = 12;
            // Попытаемся изменить с помощью конструктора (не сработает)
            // Конструктор создаёт новый объект в куче, person указывает на новый объект в куче
            person = new Person { name = "Ben", age = 47 };
        }
        // Передача ссылочного параметра по ссылке
        static void ChangePerson1(ref Person person)
        {
            person.name = "Aby";
            person.age = 20;
            // Теперь конструктор сработает
            person = new Person { name = "Ben", age = 47 };
        }
    }
    // Значимый
    struct Player
    {
        public int age;
        public string name;
    }
    // Ссылочный
    class Person
    {
        public int age;
        public string name;
    }
}
