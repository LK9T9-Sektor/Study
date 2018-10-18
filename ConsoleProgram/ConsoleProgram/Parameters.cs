using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Parameters            // 16. Массив в качестве параметра
    {
        public void Addition(params int[] numbers)
        {
            int result = 0;
            for(int i=0; i < numbers.Length; i++)
            {
                result += numbers[i];                   // суммирование эл-ов массива
                Console.Write($"{numbers[i]}\t");       // вывод эл-ов массива
            }
            Console.WriteLine($"\nСумма эл-ов массива = {result}");
        }
    }
}