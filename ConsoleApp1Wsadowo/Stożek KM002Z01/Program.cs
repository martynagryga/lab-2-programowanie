using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stożek_KM002Z01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dane = Console.ReadLine().Split(' ');
            long R = long.Parse(dane[0]);
            long L = long.Parse(dane[1]);
            decimal V = 0;

            if (R < 0 || L < 0)
            {
                Console.WriteLine("ujemny argument");
                return;
            }

            try
            {
                V = volume(R, L);
                Console.WriteLine($"{Math.Floor(V)} {Math.Ceiling(V)}");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("obiekt nie istnieje");
            }
        }

        static decimal volume(long R, long L)
        {
            double h = Math.Sqrt(-(R * R) + (L * L));
            if (double.IsNaN(h)) throw new ArithmeticException();

            return ((decimal)Math.PI * R * R * (decimal)h) / 3;
        }
    }
}
