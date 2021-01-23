using System;
using System.Collections.Generic;
using System.Text;

namespace ver2
{
    class TSphere : TCircle
    {
        public TSphere(double R) : base(R)
        { }
        public TSphere():base()
        { }
        public TSphere(TSphere b) :base(b)
        { }
        public override double S()
        {
            return 4*Math.PI*Math.Pow(R,2);
        }
        public double V()
        {
            return (4 * Math.PI * Math.Pow(R, 3))/ 3;
        }
        public override string ToString()
        {
            return "Радiус сфери = " + R;
        }
    }
}
