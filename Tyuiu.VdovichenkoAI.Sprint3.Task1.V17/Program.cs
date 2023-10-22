using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovichenkoAI.Sprint3.Task1.V17.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint3.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Вдовиченко А.И. | ИИПб-23-1";
            // Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Вдовиченко А.И. | ИИПб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле, при х=1                                                *");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 4;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Начало цикла = " + startValue);
            Console.WriteLine("Конец цикла = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
