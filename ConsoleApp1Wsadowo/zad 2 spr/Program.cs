using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2_spr
{
    class Program
    {
        static void Main(string[] args)
        {

            string A = Console.ReadLine();
            string B = Console.ReadLine();
            string C = Console.ReadLine();
            int wynik = 0;
            checked
            {
                try
                {
                    int x = int.Parse(A);
                    int y = int.Parse(B);
                    int z = int.Parse(C);
                    if (x < y && x < z)
                    {
                        if (y > z || y == z)
                        {
                            wynik = y - x;
                        }
                        else
                        {
                            wynik = z - x;
                        }


                    }
                    else if (y < x && y < z)
                    {
                        if (x > z || x == z)
                        {
                            wynik = x - y;
                        }
                        else
                        {
                            wynik = z - y;
                        }
                    }
                    else if (z < x && z < y)
                    {
                        if (x > y || x == y)
                        {
                            wynik = x - z;
                        }
                        else
                        {
                            wynik = y - z;
                        }
                    }
                    else if (x > y && x > z)
                    {
                        if (y > z || y == z)
                        {
                            wynik = x - y;
                        }
                        else
                        {
                            wynik = x - z;
                        }

                    }
                    else if (y > x && y > z)
                    {
                        if (x > z || x == z)
                        {
                            wynik = y - x;
                        }
                        else
                        {
                            wynik = y - z;
                        }
                    }
                    else if (z > x && z > y)
                    {
                        if (x > y || x == y)
                        {
                            wynik = z - x;
                        }
                        else
                        {
                            wynik = z - y;
                        }
                    }
                    Console.WriteLine(wynik);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("argument exception, exit");
                }
                catch (FormatException)
                {
                    Console.WriteLine("format exception, exit");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("overflow exception, exit");
                }
                catch (Exception)
                {
                    Console.WriteLine("non supported exception, exit");
                }
            }
        }
    }
}
