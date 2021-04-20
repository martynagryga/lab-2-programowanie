using System;

namespace wzorek {
    class Program {
        static void Main() {
            Wzorek(7);
        }

        public static void Wzorek(int n) {
            if (n % 2 == 0) n--;

            for (int i = 0; i <= n / 2; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(" ");
                }
                for (int j = 0; j < n - (i*2); j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
