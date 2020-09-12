using System;
using static System.Console;
/*
 Дисциплина: "Программирование"

Группа: БПИ202

Студент: Соколова Диана

Дата: 10.09.2020

Задача: Получить от пользователя значения напряжения U и сопротивления R, вычислить силу тока  I = U/R
и потребляемую мощность  P = U2/R электрической цепи.

*/
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 1e-12;
            Console.WriteLine("Введиите напряжение и сопротивление");
            string input = ReadLine();
            double U, R;

            if (!double.TryParse(input, out U))//ввод напряжения,проверка данных на корректность
            {
                Console.WriteLine("Ошииибка!");
                return;
            }

            input = ReadLine();
            if (!double.TryParse(input, out R))//ввод сопротивления,проверка данных на корректность
            {
                Console.WriteLine("Ошииибка!");
                return;
            }
            if (Math.Abs(R) < eps)//проверка корректности данных R!=0
            {
                Console.WriteLine("Ошииибка!");
                return;
            }
            WriteLine("I = " + U / R);//вывод силы тока
            WriteLine("P = " + U * U / R);//вывод мощности

        }
    }
}
