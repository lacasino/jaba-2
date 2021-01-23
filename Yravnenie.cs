using System;
using System.Collections.Generic;
using System.Text;

namespace ver2
{
    class Yravnenie
    {
        private double a;
        private double b;
        private double c;
        public Yravnenie (double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private bool diskOk()
        {
            double d = (Math.Pow(b, 2) - 4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("Коренів не має");
                return false;
            }
            return true;
        }
        public double[] findSolution()
        {
            double D = (Math.Pow(b, 2) - 4 * a * c);
            double[] x = new double[2];
            if (diskOk())
            {
                if (D == 0)
                {
                    x[0] = (-b - Math.Sqrt(D)) / 2 * a;
                    return x;
                }
                x[0] = (-b - Math.Sqrt(D)) / 2 * a;
                x[1] = (-b + Math.Sqrt(D)) / 2 * a;
            }
            return x;
        }
    }
}
