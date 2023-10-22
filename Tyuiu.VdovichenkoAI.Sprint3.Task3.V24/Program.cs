using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VdovichenkoAI.Sprint3.Task3.V24.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint3.Task3.V24
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
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #24                                                              *");
            Console.WriteLine("* Выполнила: Вдовиченко А.И. | ИИПб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g  на * в строке: gft hggt ntg    *");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';
            Console.WriteLine(" Искомая строка: " + value);
            Console.WriteLine(" Искомая буква, которую нужно заменить: " + replaceable);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Строка в итоге: " + ds.ReplaceCharInString(value, replaceable, replacement));
            Console.ReadKey();
        }
    }
}
