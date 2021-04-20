using System;

namespace objetoscStozka {
    class Program {
        static void Main() {
            string[] input = Console.ReadLine().Split(' ');
            long r = long.Parse(input[0]);
            long l = long.Parse(input[1]);
            decimal v = 0;

            if (r < 0 || l < 0) {
                Console.WriteLine("ujemny argument");
                return;
            }

            try {
                v = volume(r, l);
                Console.WriteLine($"{Math.Floor(v)} {Math.Ceiling(v)}");
            }
            catch (ArithmeticException) {
                Console.WriteLine("obiekt nie istnieje");
            }
        }

        static decimal volume(long r, long l) {
            double h = Math.Sqrt(-(r * r) + (l * l));
            if (double.IsNaN(h)) throw new ArithmeticException();

            return ((decimal)Math.PI * r * r * (decimal)h) / 3;
        }
    }
}
