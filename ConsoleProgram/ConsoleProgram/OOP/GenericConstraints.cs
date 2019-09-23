using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram.OOP
{
    // 41. Ограничения обобщений
    class GenericConstraints
    {
        public void Action()
        {
            Account acc1 = new Account(11) { Sum = 5000 };
            Account acc2 = new Account(44) { Sum = 3000 };

            DemandAccount acc3 = new DemandAccount(100) { Sum = 100 };
            DemandAccount acc4 = new DemandAccount(200) { Sum = 2000 };

            // Создание объектов для перевода
            Transaction<Account> t1 = new Transaction<Account>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 700
            };
            Transaction<DemandAccount> t2 = new Transaction<DemandAccount>
            {
                FromAccount = acc3,
                ToAccount = acc4,
                Sum = 700
            };
            t1.Execute();
            t2.Execute();

            Room<int> room1 = new Room<int>(11) { Number = 101, PeoplesInRoom = 3 };
            Room<int> room2 = new Room<int>(44) { Number = 412, PeoplesInRoom = 2 };

            Transfering<Room<int>> transfering1 = new Transfering<Room<int>>
            {
                FromRoom = room1,
                ToRoom = room2,
                PplNumber = 2
            };
            transfering1.Transfer();

            // Вызов ограниченного метода
            ReverseTransfer<Room<int>>(room1, room2, 2);
            
        }
        // Ограничения методов
        public void ReverseTransfer<T>(T room1, T room2, int Number) where T : Room<int>
        {
            if (room2.PeoplesInRoom > Number)
            {
                Console.WriteLine($"Комната {room2.Number}: {room2.PeoplesInRoom}\n" +
                    $"Комната {room1.Number}: {room1.PeoplesInRoom}");
                room2.PeoplesInRoom -= Number;
                room1.PeoplesInRoom += Number;
                Console.WriteLine($"Переводим {Number}\n" +
                    $"Комната {room2.Number}: {room2.PeoplesInRoom}\n" +
                    $"Комната {room1.Number}: {room1.PeoplesInRoom}");
            }
        }
    }
    // where (ограничение универсального типа)
    // Теперь можно использовать все объекты как объекты Account
    public class Transaction<T> where T : Account
    {
        public T FromAccount { get; set; }  // со счета
        public T ToAccount { get; set; }    // на счет
        public int Sum { get; set; }        // сумма

        // Перевод счета с одного на другой
        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Снятие {Sum}\n" +
                    $"Счет({FromAccount.Id}) сумма: {FromAccount.Sum}\n" +
                    $"Счет({ToAccount.Id}) сумма: {ToAccount.Sum}");
            }
            else
            {
                Console.WriteLine($"На счету({FromAccount.Id}) не достаточно денег!");
            }
        }
    }

    public class Account
    {
        public int Id { get; }
        public int Sum { get; set; }
        public Account(int _id)
        {
            Id = _id;
        }
    }
    class DemandAccount : Account
    {
        public DemandAccount(int id) : base(id)
        {

        }
    }

    // Обобщенный класс как ограничение
    class Room<T>
    {
        public T Id { get; private set; } // номер комнаты
        public int Number { get; set; }
        public int PeoplesInRoom { get; set; }

        public Room(T _id)
        {
            Id = _id;
        }
    }
    class Transfering<T> where T : Room<int>
    {
        public T FromRoom { get; set; }
        public T ToRoom { get; set; }
        public int PplNumber { get; set; }

        public void Transfer()
        {
            if (FromRoom.PeoplesInRoom > PplNumber)
            {
                Console.WriteLine($"Комната {FromRoom.Number}: {FromRoom.PeoplesInRoom}\n" +
                    $"Комната {ToRoom.Number}: {ToRoom.PeoplesInRoom}");

                FromRoom.PeoplesInRoom -= PplNumber;
                ToRoom.PeoplesInRoom += PplNumber;

                Console.WriteLine($"Переводим {PplNumber} в {ToRoom.Number}\n" +
                    $"Комната {FromRoom.Number}: {FromRoom.PeoplesInRoom}\n" +
                    $"Комната {ToRoom.Number}: {ToRoom.PeoplesInRoom}");
            }
            else
            {
                Console.WriteLine($"Недостаточно человек в комнате {FromRoom.Number}!");
            }
        }
    }
    // Стандартные ограничения
    class GenericExample1<T> where T : struct
    { }
    class GenericExample2<T> where T : class
    { }
    // Если класс или структура имеют общедоступный конструктор без параметров
    class GenericExample3<T> where T : new()
    { }
    interface IGenericExample
    { }
    class GenericExample4
    { }
    class GenEx<T> where T : GenericExample4, IGenericExample, new()
    { }
    // Использование нескольких универсальных параметров
    class GenericExample5<U, V>
        where U : GenericExample3<int>
        where V : struct
    { }
}
