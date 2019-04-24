using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 32. Индексаторы
    // Позволяют работать с объектами как с массивами
    class Indexers
    {
        public void Action()
        {
            PC pc = new PC();
            pc[0] = new Computer { Name = "Athlon" };
            pc[1] = new Computer { Name = "Intel" };
            pc[2] = new Computer { Name = "DNS" };

            Computer office = pc[0];
            Console.WriteLine(office?.Name);

            new Cpu().SetCpuInfo();

            pc[0] = new Computer { Owner = "Andrey" };
            Console.WriteLine("Владелец: " + pc[0].Owner);

            new Matrix().ChangeNumber();
        }
    }
    class Computer
    {
        public string Name { get; set; }
        public string Owner { get; set; }
    }
    class PC
    {
        // класс массив
        Computer[] data;
        public PC()
        {
            data = new Computer[7];
        }
        // Индексатор
        // модификатор Возвращаемый_тип this [способ доступа]
        public Computer this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        // Индексы не обязательно могут быть int
        // Передача атрибута в виде строки

        // Перегрузка индексаторов
        public Computer this[string owner]
        {
            get
            {
                Computer comp = null;
                foreach(var p in data)
                {
                    if(p?.Owner == owner)
                    {
                        comp = p;
                        break;
                    }
                }
                return comp;
            }
        }
    }
    class Cpu
    {
        string name;
        int core_numbers;
        double frequency;

        public string this[string specification]
        {
            get
            {
                switch (specification)
                {
                    case "name": return name;
                    case "core_numbers": return ", ядер: " + Convert.ToString(core_numbers);
                    case "frequency": return ", частота: " + Convert.ToString(frequency) + " GHz";
                    default: return null;
                }
            }
            set
            {
                switch (specification)
                {
                    case "name":
                        name = value;
                        break;
                    case "core_numbers":
                        core_numbers = Convert.ToInt32(value);
                        break;
                    case "frequency":
                        frequency = Convert.ToDouble(value);
                        break;
                }
            }
        }
        public void SetCpuInfo()
        {
            Cpu cpu = new Cpu();
            cpu["name"] = "AMD Phenom 8450";
            cpu["core_numbers"] = "3";
            cpu["frequency"] = "2100";
            Console.WriteLine(cpu["name"] + cpu["core_numbers"] + cpu["frequency"]);
        }
    }
    // Передача нескольких параметров
    class Matrix
    {
        private int[,] numbers = new int[,] { { 3, 4, 1 }, { 1, 2, 6 }, { 7, 1, 2 } };

        public int this [int i, int j]
        {
            get { return numbers[i, j]; }
            set { numbers[i, j] = value; }
        }
        public void ChangeNumber()
        {
            again:
            try
            {
                Matrix matrix = new Matrix();
                Console.Write("\n\tМатрица 3x3\n" +
                    "Введите позицию i для замены: ");
                int i = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите позицию j для замены: ");
                int j = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"({i} {j}) = " + matrix[i, j]);
                Console.Write("Введите число для замены: ");
                int n = Convert.ToInt32(Console.ReadLine());
                matrix[i, j] = n;
                Console.WriteLine($"({i} {j}) = " + matrix[i, j]);
            }
            catch (IndexOutOfRangeException)
            {                
                Console.WriteLine("Недопустимый диапазон");
                goto again;
            }
        }
    }
}
