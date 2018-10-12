using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    class Array
    {
        public int Action()
        {
            Console.WriteLine("\t Одномерные массивы");
            int[] nu = new int[4]; // будет заполнен нулями
            int[] num = new int[4] { 1, 2, 3, 4, };
            int[] numb = { 1, 2, 3, 4 };
            int n = numb[0];        //1
            Console.WriteLine(numb[0]);
            numb[0] = 7;            // присвоение 0 элементу 7
            Console.WriteLine(numb[0]);
            Console.WriteLine("\t Использование foreach для вывода значений в массиве");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\t Использование for для вывода значений в массиве");
            for (int i=0; i < 4; i++)  // num.Length - массив.Кол-во элементов
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("\t Двумерные массивы");
            // Способы объявления массивов
            int[,] nums1;                       // двумерный массив
            int[,] nums2 = new int[2, 3];       // 2-ый int массив; 2 строки по 3 элемента(столбца);
            int[,] nums3 = new int[2, 3] { { 0, 1, 2 },{ 3, 4, 5 } };   // 2-йы int; 2x3; {{значения}}
            int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };     // 2-ый int; ; {{значения}}
            int[,] nums5 = new[,] { { 0, 1, 2, }, { 3, 4, 5 } };        // 2-ый; ; {{значения}}
            int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };                // 2-ый; {{значения}}

            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            foreach (int i in mas)  // вывод элементов массива в строку
                Console.Write($"{i} ");
                //Console.WriteLine($"{i} "); // вывод элементов построчно
                Console.WriteLine();

            Console.WriteLine("\t Использование Length");
            int[] nums = new int[10];
            Console.WriteLine("Длина массива nums равна " + nums.Length);
            for (int i = 0; i < nums.Length; i++)
                nums[i] = i * i;                // перемножение эл-а массива самого на себя (2 степень)      
            Console.Write("Содержимое массива nums: "); // вывод содержимого массива nums
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
            Console.WriteLine();

            Console.WriteLine("\t Использование GetUpperBound(dimension)");
            int[,] a = { { 2, 2}, { 3, 2}, { 2, 2 }, { 3, 4 }, { 6, 6 } };
            // кол-во строк (i) или (x) = кол возвращенных индексов последних эл-ов
            int rows = a.GetUpperBound(0)+1;    
            int columns = a.Length / rows;      // кол-во столбцов (j)  (y)
            
            for (int i=0; i < rows; i++)        // строки
            {
                for (int j = 0; j < columns; j++)   // столбцы
                {
                    Console.Write($"{a[i, j]} \t"); // вывод значения
                }
                Console.WriteLine();            // ставим переходы на новую строку
            }

            Vvod();                             // переход на метод

            return 0;
        }
        
        public int Vvod()
        {
            Console.WriteLine("\t Двумерный массив, ввод кол-ва элементов и самих эле-ов");
            /* b - кол-во эл-ов 1 ранга; c - кол-во эл-ов 2 ранга;
             * d - счётчик по b-строкам; e - счётчик по c-столбцам)
            */
            Console.Write("Введите кол-во строк): ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[b, c];
            Console.WriteLine("\nНажмите r для заполнение массива случайными числами \n" +
                "Для ввода элементов собственноручно, нажмите любую клавишу");
            string question = Console.ReadLine();
            if (question == "r")
            {
                Console.Write("Случайные числа от: ");
                int f = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Случайные числа от {f} до: ");
                int g = Convert.ToInt32(Console.ReadLine());
                Random r = new Random();            // переменная для рандома
                for (int d = 0; d < b; d++)
                {
                    for (int e = 0; e < c; ++e)
                    {
                        array[d, e] = r.Next(f, g); // Случаыйне числа от f до g
                    }
                }
            }
            else
            {
                Console.WriteLine("Вводите элементы через Enter: ");
                for (int d = 0; d < b; ++d)
                {
                    for (int e = 0; e < c; ++e)
                    {
                        array[d, e] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("\t\tПолученный массив:");
            for (int d = 0; d < b; ++d)
            {
                for (int e = 0; e < c; ++e)
                {
                    Console.Write(array[d, e] + "\t");      // перевод строки
                }
                Console.WriteLine("");                      // вывод элементов
            }

            return 0;
        }
    }
}
