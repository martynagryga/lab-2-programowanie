using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_7_spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = sbyte.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            sbyte[] numbers1 = Array.ConvertAll<string, sbyte>(input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), sbyte.Parse);

            sbyte n2 = sbyte.Parse(Console.ReadLine());
            input = Console.ReadLine();
            sbyte[] numbers2 = Array.ConvertAll<string, sbyte>(input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), sbyte.Parse);

            float sum1 = 0;
            float sum2 = 0;

            for (int i = 0; i < n1; i++) sum1 += numbers1[i];
            sum1 /= n1;

            for (int i = 0; i < n2; i++) sum2 += numbers2[i];
            sum2 /= n2;

            if (sum2 < sum1)
            {
                for (int i = 0; i < n1; i++)
                {
                    Console.Write(numbers1[i]);
                    Console.Write(' ');
                }
            }
            else
            {
                for (int i = 0; i < n2; i++)
                {
                    Console.Write(numbers2[i]);
                    Console.Write(' ');
                }
            }
            Console.WriteLine("");
        }
    }
}
