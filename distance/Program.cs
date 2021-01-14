using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            double x1 = 3;
            double y1 = 7;
            double x2 = 1;
            double y2 = 6;

            Console.Write("Программа для подсчета расстояния между точками. " +
                Environment.NewLine + "Координаты точек ({0}; {1}) и ({2}; {3})" +
                Environment.NewLine + "Расстояние: ", x1, y1, x2, y2);
          
            #region Task1
            x1 = Convert.ToDouble(x1);
            y1 = Convert.ToDouble(y1);
            x2 = Convert.ToDouble(x2);
            y2 = Convert.ToDouble(y2);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.Write("{0:F2}", r);
            #endregion

            #region Task2
            double distance = Distance(x1, y1, x2, y2);

            Console.Write(Environment.NewLine + "Расстояние: " + "{0:F2}", distance);
            #endregion

            Console.ReadKey();

        }

 
        }
    }
