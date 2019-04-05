using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    /* Переменные структуры хранят не ссылку на объект, а сам объект. Т.е. это значимый тип, а не ссылочный.
    Если одной структуре присвоить другую, то скопируются Все Поля одной структуры в другую, а не ссылка, как было бы с классами.
    Т.к. переменная хранит сами данные, а не ссылку на них, то доступ к полям осуществляется быстрее и
    есть некоторая экономия памяти. Структуры хранятся в стеке. Структуры не поддерживают наследование!
    */
    // структуры определяются вне класса
    struct UserStruct
    {
        // в отличии от класса нельзя инициализировать поля структуры напрямую при их объявлении!
        //public string town = "Krasnoyarsk"; // ошибка
        public string name;
        public int age;

        // определяем конструктор
        // конструктор в структуре, должен(!) инициализировать все поля структуры
        public UserStruct(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}");
        }
    }
    class Structures
    {
        public void Action()
        {
            // массив структур
            UserStruct[] users = new UserStruct[3];
            users[0].name = "Bob";
            users[0].age = 20;
            users[1].name = "Sam";
            users[1].age = 30;
            // вызов конструктора в массиве
            users[2] = new UserStruct("Mad", 999);

            // вывод из массива
            foreach(UserStruct user in users)
            {
                user.DisplayInfo();
            }

            UserStruct tom;
            tom.name = "Tom";
            tom.age = 33;
            int d = tom.age;

            tom.DisplayInfo();

            // передача в конструктор
            UserStruct din = new UserStruct("Din", 43);

            // структура имеет пустой конструктор по умполчанию
            UserStruct Empty = new UserStruct();
            Empty.DisplayInfo();
        }
    }
}
