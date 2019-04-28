using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 39. Класс System.Object и его методы
    // Все классы в .NET являются неявно производными от Object
    // Производные классы могут переопределять методы от класса Object
    // Equals, Finalize, GetHashCode, ToString
    class ObjectClass
    {
        public void Action()
        {
            // ToString - строковое представление объекта
            double a = 12.234;
            Console.WriteLine(a.ToString());

            // ToString
            ObjClockOwner owner = new ObjClockOwner();
            Console.Write("Введите имя или нажмите Enter: ");
            owner.Name = Console.ReadLine();
            // Вывелет название класса ObjClockOwner или введеное имя
            Console.WriteLine(owner.ToString());

            ObjClock clock = new ObjClock { Hours = 23, Minutes = 9, Seconds = 11 };
            // Выведет 23:9:11, т.к. метод переопределен
            Console.WriteLine(clock.ToString());

            // GetHashCode - возвращает числовое значение. По нему можно сравнивать объекты
            Console.WriteLine("Хеш-код 1 owner'a: "+ owner.GetHashCode());
            ObjClockOwner owner1 = new ObjClockOwner();
            owner1.Name = "Lex";
            Console.WriteLine("Хеш-код 2 owner'a: " + owner1.GetHashCode());

            // GetType - получение типа объекта
            Console.WriteLine(owner.GetType());
            // Сравниваем с помощью typeof
            object owner2 = new ObjClockOwner { Name = "Sten" };
            if (owner2.GetType() == typeof(ObjClockOwner))
                Console.WriteLine("Это класс ObjClockOwner");

            // Equals - сравниваем два объекта на равенство
            ObjClockOwner owner4 = new ObjClockOwner { Name = "Pedro" };
            ObjClockOwner owner5 = new ObjClockOwner { Name = "Pablo" };
            ObjClockOwner owner6 = new ObjClockOwner { Name = "Pedro" };
            // Сравнение owner4 с owner5
            bool ow4_ow5 = owner4.Equals(owner5);   
            Console.WriteLine(ow4_ow5); // false
            // Сравнение owner4 с owner6
            bool ow4_ow6 = owner4.Equals(owner6);
            Console.WriteLine(ow4_ow6); // true
        }
    }

    class ObjClock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        // Переопределили метод ToString
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }
    class ObjClockOwner
    {
        public string Name { get; set; }
        // Переопределили метод ToString
        public override string ToString()
        {
            // Проверяем строку на пустоту
            if (String.IsNullOrEmpty(Name))
                return base.ToString(); // возвращаем название класса
            return Name;    // если не пусто вернём полученное имя
        }
        // Переопределяем базовую реализацию метода GetHashCode
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        // Переопределяем метод Equals
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            ObjClockOwner owner3 = (ObjClockOwner)obj;
            return (this.Name == owner3.Name);

        }
    }
}
