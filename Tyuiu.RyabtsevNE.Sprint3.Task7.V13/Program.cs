using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RyabtsevNE.Sprint3.Task7.V13.Lib;

namespace Tyuiu.RyabtsevNE.Sprint3.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Рябцев Н. Е. | СМАРТб-24-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Обработка целочисленной информации                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Рябцев Никита Евгеньевич | СМАРТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-------------+------------+");
            Console.WriteLine("|      X     |    f(x)     |");
            Console.WriteLine("+-------------+------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,7:d}     |  {1, 7:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+------------+-------------+");
            Console.ReadKey();



        }
    }
}
