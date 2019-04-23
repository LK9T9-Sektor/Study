using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{   
    //31. Оператор null-объединения (??), условный null (?)
    class NullOperator
    {
        // Если переменной ссылочного типа не присвоили значение, то она будет null
        public void Action()
        {
            // ?? - устанавливает значения по умолчанию
            object a = null;
            object b = a ?? 69; // т.к. левый операнд = null, присвоит 69
            Console.WriteLine(b);

            string c = "";
            string d = c ?? "20"; // присвоения не будет, т.к. c != null, пустая строка допустима
            Console.WriteLine("Для string: " + d + "...пустой символ допустим");

            // Условный null

            /* NullReferenceException
            Worker worker = new Worker();
            Console.WriteLine(worker.Phone.Company.Name);
            */

            // Условная конструкция для проверки на null
            Worker worker = new Worker();

            if(worker != null && worker.Phone != null && worker.Phone.Company != null)
            {
                string companyName = worker.Phone.Company.Name;
                Console.WriteLine(companyName);
            }
            else
            {
                Console.WriteLine("Данные о компании не внесены!");
            }

            // Тоже самое но с использованием ?
            Worker worker1 = new Worker();
            string companyName1 = worker?.Phone?.Company?.Name ?? "Внесите данные о компании";
            Console.WriteLine(companyName1);
        }
    }
    
    // Свойства ниже не определены, содержат null, может получить ошибку
    class Worker
    {
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }

}
