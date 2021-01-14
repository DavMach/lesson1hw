using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bodymassindex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа для рассчета индекса массы тела (ИМТ) " +
                Environment.NewLine + "Введите свой рост: ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Введите свой вес: ");
            double m = double.Parse(Console.ReadLine());

            h /= 100;

            Double i = m / (h * h);

            Console.WriteLine($"ИМТ = {i} ");
            Console.ReadKey();

        }
    }
}
