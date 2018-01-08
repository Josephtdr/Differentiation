using System;

namespace Numerical_Methods__Gradient_ {
    class Program {
        static void Main(string[] args) {
            double x = 4; //value at which gradient will be found
            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("H = {0,-20} x = {1,-5}: Forward Difference {2,-20} Central Difference {3}"
                , Math.Pow(0.5, i), x , Central_Difference(x, Math.Pow(0.5, i), f), Forward_Difference(x, Math.Pow(0.5, i), f));
            }
            Console.ReadKey();
        }

        //input equations here
        public static double f(double x) {
            return (Math.Pow(x, 5) - 4 * x);
        }
        public static double g(double x) {
            return (Math.Pow(x, 3) - 7 * Math.Pow(x, 2) + 3 * x + 5);
        }

        //methods here, [change f → g (e.t.c) for different functions]
        static double Forward_Difference(double x, double h, Func<double, double> F) {
            return ((F(x + h) - F(x)) / h);
        }
        static double Central_Difference(double x, double h, Func<double, double> F) {
            return ((F(x + h) - F(x - h)) / (h * 2));
        }

    }
}
