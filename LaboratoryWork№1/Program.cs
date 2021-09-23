using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork_1
{
    class Program
    {
        static double GetAnswer(double a, double b)
        {
            double answer = (Math.Pow((a - b), 3) - Math.Pow(a, 3))/(3*a*Math.Pow(b,2)- Math.Pow(b, 3)-3*b*Math.Pow(a,2));
            return answer;
        }
        static void GetMandN(ref int m, ref int n) 
        {
            bool OK;
            OK = false;
            do
            {
                Console.Write("Введите m: \t");
                OK = int.TryParse(Console.ReadLine(), out m);
                if (!OK)
                    Console.WriteLine("Невозможно вычислить m");
            } while (!OK);
            OK = false;
            do
            {
                Console.Write("Введите n: \t");
                OK = int.TryParse(Console.ReadLine(), out n);
                if (!OK)
                    Console.WriteLine("Невозможно вычислить n");
            } while (!OK);
        }
        static void GetXandY(ref double x, ref double y)
        {
            bool OK;
            OK = false;
            do
            {
                Console.Write("Введите первую координату: \t");
                OK = double.TryParse(Console.ReadLine(), out x);
            } while (!OK);
            OK = false;
            do
            {
                Console.Write("Введите вторую координату: \t");
                OK = double.TryParse(Console.ReadLine(), out y);
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
            //FIRST PART
            int n = 0, m = 0;
            GetMandN(ref m, ref n);
            int r1 = n++ * m;
            Console.Write("1)      ");
            Console.WriteLine("n = " + n +"; m = "+m+"\n\tm ++* n = "+r1+"\n\n");

            bool r2 = n++<m;
            Console.Write("2)      ");
            Console.WriteLine("n = " + n + "; m = " + m + "\n\tn ++< m = " + r2 + "\n\n");

            bool r3 = --m>n;
            Console.Write("3)      ");
            Console.WriteLine("n = " + n + "; m = " + m + "\n\t--m > n = " + r3 + "\n\n");

            Console.Write("4)      ");
            bool OK = false;
            double x;
            do
            {
                Console.Write("Введите x (>=0): \t");
                OK = double.TryParse(Console.ReadLine(), out x);
                if (!OK)
                    Console.WriteLine("Невозможно вычислить x");
            } while (!OK||x<0);
            double r4;
            r4 = Math.Pow(x-Math.Pow(x,2)+ Math.Pow(x, 5), 1.0 / 3.0);
            Console.WriteLine("\tr4 = " + r4);

            //SECOND PART
            Console.WriteLine("\n\n\n2 ЧАСТЬ ЗАДАНИЯ");
            double xCoord = -1, yCoord = -1;
            GetXandY(ref xCoord, ref yCoord);
            Console.WriteLine("x = " + xCoord + "\ny = " + yCoord);
            ContainFigure(xCoord, yCoord);

            //THIRD PART
            Console.WriteLine("\n\n\n3 ЧАСТЬ ЗАДАНИЯ");
            double a = 1000; double b = 0.0001;
            double result = GetAnswer(a, b);
            Console.WriteLine("Результат тип double = " + result);
            Console.WriteLine("Результат тип float = " + (float)result);
        }
    }
}
