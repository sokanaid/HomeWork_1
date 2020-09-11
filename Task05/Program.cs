
using System;

/*
 Дисциплина: "Программирование"

Группа: БПИ202

Студент: Соколова Диана

Дата: 10.09.2020

Задача: Получить от пользователя значения длин двух катетов, вычислить и вывести на экран значение гипотенузы.

*/
namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 1e-12;
            Console.WriteLine("Введите длины катетов");
            string input = Console.ReadLine();//ввод первого катета
            double k1, k2;

            if (!double.TryParse(input, out k1))//проверка данных на корректность
            {
                Console.WriteLine("Ошииибка!");
                return;
            }

            input = Console.ReadLine();//ввод второго катета

            if(!double.TryParse(input, out k2))//проверка данных на корректность
            {
                Console.WriteLine("Ошииибка!");
                return;
            }

            if(k1<eps || k2 < eps)//проверка данных на корректность
            {
                Console.WriteLine("Ошииибка!");
                return;
            }
            double ans = Math.Sqrt((k1 * k1 + k2 * k2));//вычисление гипотенузы
            Console.WriteLine("Длина гипотенузы :"+ans);//вывод длины гипотенузы

        }
    }
}
