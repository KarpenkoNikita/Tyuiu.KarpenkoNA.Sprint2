using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KarpenkoNA.Sprint2.Task5.V8.Lib;

namespace Tyuiu.KarpenkoNA.Sprint2.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Карпенко Н.А. | АСОиУБ-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Карпенко Никита Андреевич |  АСОиУБ-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется двумя натуральными         *");
            Console.WriteLine("* числами: m (порядковый номер месяца) и n (число). По заданным n и m     *");
            Console.WriteLine("* определить дату предыдущего дня (принять, что n и                       *");
            Console.WriteLine("* m не характеризуют 1 января).                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дня: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string res;
            if (((m < 1) && (m > 12)) || ((n > 31) && (n <= 1)))
            {
                res = "Ошибка";
            }
            else
            {
                res = "Дата предыдущего дня" + ds.FindDateOfPreviousDay(m, n);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
