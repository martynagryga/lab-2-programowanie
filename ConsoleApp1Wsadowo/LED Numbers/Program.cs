using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    int number = int.Parse(input[j].ToString());
                    if (i == 1)
                    {
                        if (number != 1 && number != 4)
                        {
                            Console.Write(" _ ");
                        }
                        else Console.Write("   ");
                    }
                    else if (i == 2)
                    {
                        if (number != 1 && number != 3 && number != 7 && number != 2)
                        {
                            Console.Write("|");
                        }
                        else Console.Write(" ");

                        if (number != 0 && number != 1 && number != 7)
                        {
                            Console.Write("_");
                        }
                        else Console.Write(" ");

                        if (number != 5 && number != 6)
                        {
                            Console.Write("|");
                        }
                        else Console.Write(" ");
                    }
                    else if (i == 3)
                    {
                        if (number == 0 || number == 2 || number == 6 || number == 8)
                        {
                            Console.Write("|");
                        }
                        else Console.Write(" ");

                        if (number != 1 && number != 4 && number != 7 && number != 9)
                        {
                            Console.Write("_");
                        }
                        else Console.Write(" ");

                        if (number != 2)
                        {
                            Console.Write("|");
                        }
                        else Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
