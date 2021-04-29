using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_spr
{
    class Program
    {
        static void Main(string[] args)
        {           
            int[,] x = new int[3, 1] {
                { -1 },
                { -1 },
                { -1},
            };

            Console.WriteLine(Srednia(x).ToString("F"));
        }


        public static double Srednia(int[,] y)
        {
            if (y == null) return 0;

            long suma = 0;
            long n = 0;

            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y.GetLength(1); j++)
                {
                    if (y[i, j] > 0)
                    {
                        suma += y[i, j];
                        n += 1;
                    }
                }
            }

            if (n == 0) return 0;

            return (double)suma / n;

        }
    }
}
