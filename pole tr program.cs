using System;

namespace poleTrojkata {
    class Program {
        static void Main() {
            try {
                Console.WriteLine(TriangleArea(2, -3, 4, 4));
            } catch {

            }
        }

        public static double TriangleArea(int a, int b, int c, int precision = 2) {
            if (precision < 2 || precision > 8 || a < 0 || b < 0 || c < 0) {
                Console.WriteLine("wrong arguments");
                throw new ArgumentOutOfRangeException();
            }

            if (a > b + c || b > c + a || c > a + b) {
                Console.WriteLine("object not exist");
                throw new ArgumentException();
            }

            double p = ((double)a + b + c) / 2;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return Math.Round(Area,precision);
        }
    }
}
