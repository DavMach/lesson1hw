using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Урок 1. Введение. Базовые типы данных. Консоль. Классы и методы.
// Мачитидзе Давид
// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.


namespace questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            int e;

            Console.Write("Пожалуйста заполните анкету: ");

            Console.Write("Имя: ");
            string inputA = Console.ReadLine();
            Console.Write("Фамилия: ");
            string inputB = Console.ReadLine();
            Console.Write("Отчество: ");
            string inputC = Console.ReadLine();
            Console.Write("Рост: ");
            string inputD = Console.ReadLine();
            Console.Write("Вес: ");
            string inputE = Console.ReadLine();

            d = Convert.ToInt32(inputD);
            e = Convert.ToInt32(inputE);

            #region Task1
            // а) используя склеивание;
            Console.WriteLine("Имя: " + inputA + " " + "Фамилия: " + inputB + " " + "Отчество: " + inputC + " " + "Рост: " + inputD + " " + "Вес: " + inputE);
            #endregion

            #region Task2
            // б) используя форматированный вывод;
            Console.WriteLine("Имя: {0} Фамилия: {1} Отчество: {2} Рост: {3} Вес: {4}", inputA, inputB, inputC, inputD, inputE);
            #endregion

            #region Task3
            // в) *используя вывод со знаком $.
            Console.WriteLine($"Имя: {inputA} Фамилия: {inputB} Отчество: {inputC} Рост: {inputD} Вес: {inputE}");
            #endregion
        }
    }
}
