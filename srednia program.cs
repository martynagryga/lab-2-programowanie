using System;

namespace srednia {
    class Program {
        static void Main() {
            //int[,] arr = new int[3, 6] { 
            //    { 1,1,1,1,1,1 }, 
            //    { 2,2,2,2,2,2 }, 
            //    { 3,3,3,3,3,3 },
            //};
            int[,] arr = new int[3, 1] {
                { -1 },
                { -1 },
                { -1},
            };

            Console.WriteLine(Srednia(arr).ToString("F"));
        }


        public static double Srednia(int[,] tab) {
            if (tab == null) return 0;

            long sum = 0;
            long n = 0;

            for (int i = 0; i < tab.GetLength(0); i++) {
                for (int j = 0; j < tab.GetLength(1); j++) {
                    if (tab[i, j] > 0) {
                        sum += tab[i, j];
                        n += 1;
                    }
                }
            }

            if (n == 0) return 0;

            return (double)sum/n;
        }
    }
}
