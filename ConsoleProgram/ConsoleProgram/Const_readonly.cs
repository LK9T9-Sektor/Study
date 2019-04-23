using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgram
{
    // 29. Константы и поля для чтения
    class Const_readonly
    {        
        public void Action()
        {
            Console.WriteLine("Число Пи = " + MathLib.PI);
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь = " + new MathLib().GetCircleArea(radius));            
        }
    }
    class MathLib
    {
        public const double PI = 3.141592;
        const double E = 2.718281;

        public double GetCircleArea(double radius)
        {
            return PI * radius * radius;
        }

    }
    // Поля для чтения
    class ReadOnlyFields
    {
        public readonly int D = 666; // инициализация
        public ReadOnlyFields()
        {
            // readonly поле может быть инициализировано или изменено в конструкторе
            // после компиляции
            D = 45;
        }
        public void ChangeField()
        {
            // D = 333; // нельзя
        }
    }
    class Field
    {
        static void Show()
        {
            // Можно только считать значение для readonly
            ReadOnlyFields readOnlyFields = new ReadOnlyFields();
            //int z = readOnlyFields.D;
            Console.WriteLine(readOnlyFields.D);
        }
    }
}
