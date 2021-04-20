using System;

namespace pierwiastki {
    class Program {
        static void Main() {
            // test
            QuadraticEquation(100000, 6000, -30000);
        }

        public static void QuadraticEquation(int a, int b, int c) {
            double delta = ((double)b * b) - (4 * (double)a * c);

            if (a == 0 && b == 0 && c == 0) {
                Console.WriteLine("infinity");
                return;
            }
            if (a == 0 && b == 0) {
                Console.WriteLine("empty");
                return;
            }
            if (a == 0) {
                Console.WriteLine($"x={-((double)c /b):F2}");
                return;
            }

            if(Math.Round(delta, 2) > 0) {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * (double)a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * (double)a);
                Console.WriteLine($"x1={x1:F2}");
                Console.WriteLine($"x2={x2:F2}");
                return;
            }
            if (Math.Round(delta, 2) == 0) {
                double x1 = (-b) / (2 * (double)a);
                Console.WriteLine($"x={x1:F2}");
                return;
            }

            Console.WriteLine("empty");
        }
    }
}
