using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1_test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        n--;
                    }
                }
            }
            Console.WriteLine(n);
        }
    }
}
