using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int N = Int32.Parse(n);
            for (int i = 0; i < N-1; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == 0 || i == N - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    if (i == 0 || i == N - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                
            }
        }
    }
}
