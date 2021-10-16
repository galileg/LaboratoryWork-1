using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void D(int a, double b)
        {
            double c = a - b;
            double d = Math.Pow(c, 3);
            double E = d - Math.Pow(a, 3);
            double f = 3 * a * Math.Pow(b, 2);
            double g = f - Math.Pow(b, 3);
            double h = 3 * b * Math.Pow(a, 2);
            double I = g - h;
            double answer = E / I;
            
            Console.WriteLine("\n   Результат тип double = " + answer);
        }

        static void F(int a, float b)
        {
            float c = a - b;
            float d = c*c*c;
            float E = d - a*a*a;
            float f = 3 * a * b*b;
            float g = f - b*b*b;
            float h = 3 * b * a*a;
            float I = g - h;
            float answer = E / I;

            Console.WriteLine("   Результат тип float = " + answer);
        }

        static void Main(string[] args)
        {
            int a = 1000;
            float b = 0.0001f;
            D(a, b);
            F(a, b);
        }
    }
}
