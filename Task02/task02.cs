﻿using System;
/*
 Дисциплина: "Программирование"

Группа: БПИ202

Студент: Соколова Диана

Дата: 10.09.2020

Задача: В текстовом режиме выведите в консольное окно изображение вашей фамилии,
составленное из выбранных вами символов ('*', 'x', проч.). 

*/
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //вывод Соколова
            Console.Write(" * *    * *    *   *    * *     * * *    * *    * * *       *\n*      *   *   * *     *   *    *   *   *   *   *   *      * *\n");
            Console.Write("*      *   *   **      *   *    *   *   *   *   * *       * * *\n*      *   *   * *     *   *    *   *   *   *   *   *    *     *\n");
            Console.Write(" * *    * *    *   *    * *   *     *    * *    * * *   *       *");
        }
    }
}
