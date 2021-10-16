using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void GetXandY(ref double x)
        {
            bool OK;
            do
            {
                Console.Write("Введите координату: \t");
                OK = double.TryParse(Console.ReadLine(), out x);
                if (!OK)
                    Console.WriteLine("Невозможно вычислить координату");
            } while (!OK);
        }

        static void ContainFigure(double x, double y)
        {
            double hipo = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            if (hipo <= 1)
            {
                Console.WriteLine("Точка принадлежит фигуре");
                if (hipo == 1)
                    Console.WriteLine("Точка находится на границе");
            }
            else
                Console.WriteLine("Точка не принадлежит фигуре");
        }
        static void Main(string[] args)
        {
            //SECOND PART
            Console.WriteLine("2 ЧАСТЬ ЗАДАНИЯ");
            double xCoord = -1, yCoord = -1;
            GetXandY(ref xCoord);
            GetXandY(ref yCoord);
            Console.WriteLine("x = " + xCoord + "\ny = " + yCoord);
            ContainFigure(xCoord, yCoord);

        }
    }
}
