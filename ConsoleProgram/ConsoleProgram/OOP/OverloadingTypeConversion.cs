using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 35. Перегрузка операций преобразования типов. explicit, implicit
    class OverloadingTypeConversion
    {
        public void Action()
        {
            OTC_Counter oTC_Counter1 = new OTC_Counter { Seconds = 44 };
            // Приведение типов
            int x = (int)oTC_Counter1;
            Console.WriteLine(x);   // 44

            OTC_Counter oTC_Counter2 = x;
            Console.WriteLine(oTC_Counter2.Seconds);    // 44

            Console.Write("Введите кол-во секунд: ");
            int z = Convert.ToInt32(Console.ReadLine());
            OTC_Counter counter1 = new OTC_Counter { Seconds = z };

            // Отобразим часы, минуты, секунды
            OTC_Timer timer = counter1;            
            Console.WriteLine("Ч:М:С: " + 
                $"{timer.Hours}:{timer.Minutes}:{timer.Seconds}");

            OTC_Counter counter = (OTC_Counter)timer;
            Console.WriteLine("И обратно кол-во секунд: " + counter.Seconds);
        }
    }
    // Счётчик-секундомер
    class OTC_Counter
    {
        public int Seconds { get; set; }

        // Явное преобразование, implicit
        // объект типа int к типу Counter
        public static implicit operator OTC_Counter(int x)
        {
            return new OTC_Counter { Seconds = x };
        }

        // Неявное преобразование, explicit
        // Counter к типу int
        public static explicit operator int(OTC_Counter otc_counter)
        {
            return otc_counter.Seconds;
        }

        // Преобразования из одного составного типа в другой составной тип
        public static explicit operator OTC_Counter(OTC_Timer timer)
        {
            int h = timer.Hours * 3600;
            int m = timer.Minutes * 60;
            return new OTC_Counter { Seconds = h + m + timer.Seconds };
        }
        public static implicit operator OTC_Timer(OTC_Counter counter)
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds - h * 3600) / 60;
            int s = counter.Seconds - h * 3600 - m * 60;
            return new OTC_Timer { Hours = h, Minutes = m, Seconds = s };
        }
    }

    // Таймер хранящий часы, минуты, секунды
    class OTC_Timer
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
    }
}
