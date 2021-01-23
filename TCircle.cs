using System;
using System.Collections.Generic;
using System.Text;

namespace ver2
{
    class TCircle
    {
        protected double R;   
        public TCircle(double R)
        {
            this.R = R;
        }
        public TCircle()
        {
            this.R = 0; 
        }
        public TCircle(TCircle b)
        {
            this.R = b.R;
        }
        public override string ToString()
        {
            return "Радiус кола = " + R;
        }
        public virtual double S()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public double LenghtCircle()
        {
            return R + R;
        }
        public static bool operator > (TCircle a, TCircle b)
        {
            return a.R > b.R;
        }
        public static bool operator < (TCircle a, TCircle b)
        {
            return a.R < b.R;
        }
        public static TCircle operator + (TCircle a, TCircle b)
        {
            return new TCircle (a.R + b.R);
        }
        public static TCircle operator - (TCircle a, TCircle b)
        {
            return new TCircle(a.R - b.R);
        }
        public static double operator * (TCircle a, double b )
        {
            return a.R * b;
        }
        public static double operator *(double a, TCircle b)
        {
            return a * b.R;
        }
    }
}
