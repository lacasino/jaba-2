using System;

namespace ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Yravnenie imya = new Yravnenie(1, -2, -3); // 1,4,4 - 1  корень | 1,6,45 - 0 корней  
            double[] asd = imya.findSolution();
            Console.WriteLine("{0}, {1}", asd[0], asd[1]);
            TSphere b1 = new TSphere(5);
            Console.WriteLine(b1);
        }
    }
}
