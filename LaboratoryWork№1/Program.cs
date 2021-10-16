using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork_1
{
    class Program
    {
        
        static void GetMandN(ref int n) 
        {
            bool OK;
            OK = false;
            do
            {
                Console.Write("Введите число: \t");
                OK = int.TryParse(Console.ReadLine(), out n);
                if (!OK)
                    Console.WriteLine("Невозможно вычислить ");
            } while (!OK);
        }
  
        
        static void Main(string[] args)
        {
            //FIRST PART
            int n = 0, m = 0;
            GetMandN(ref n);
            GetMandN(ref m);
            
            int r1 = m++ * n;
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
                Console.Write("Введите x: \t");
                OK = double.TryParse(Console.ReadLine(), out x);
                if (!OK)
                    Console.WriteLine("Невозможно вычислить x");
            } while (!OK);


            double r4 = Math.Sign(x) * Math.Pow(Math.Abs(x - Math.Pow(x, 2) + Math.Pow(x, 5)), (1.0 / 3.0)); 

            Console.WriteLine("\tr4 = " + r4);

        }
    }
}
