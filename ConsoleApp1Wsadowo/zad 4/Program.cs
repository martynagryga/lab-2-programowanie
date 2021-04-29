using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[3][]
            {
                  new int[] {-1},
                  new int[] {1},
                  new int[] {1}
            };
            double result = Srednia(tab);
            Console.WriteLine(result);
        }
        public static double Srednia(int[][] tab)
        {
            double sum = 0f;
            double y = 0f;
            int counter = 0;
            if (tab == null)
            {
                y = 0.00f;
                return y;
            }
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] != null)
                {
                    for (int j = 0; j < tab[i].Length; j++)
                    {
                        if (tab[i][j] > 0)
                        {
                            sum += tab[i][j];
                            counter++;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                y = 0.00f;
                return y;
            }
            else
            {
                y = Math.Round(sum / counter, 2);
                return y;
            }
        }
    }
}
