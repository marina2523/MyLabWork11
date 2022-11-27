// See https://aka.ms/new-console-template for more information
using System;
namespace Program
{
    class Program
    {
        static void Main ()
        {
            double s = 0;
            int n = 1;
            double x = 0.7;
            double e = 0.0001;
            do
            {
                x = (Math.Pow(x, 2 * n) / (2 * n));
                s += x;
                n++;
            }
            while (Math.Abs(x) > e);
            Console.WriteLine($"Сумма членов ряда с заданной точностью =" + s.ToString()); 
        }
    }
}
