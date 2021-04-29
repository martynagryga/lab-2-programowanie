using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    class Program
    {
        static void Main(string[] args)

        {
            int numberOfCases = int.Parse(Console.ReadLine());
            for (int a = 0; a < numberOfCases; a++)
            {
                string[] input = Console.ReadLine().Split(new[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int mSize = int.Parse(input[0]);
                int nSize = int.Parse(input[1]);
                char[][] arr = new char[mSize][];

                for (int i = 0; i < mSize; i++)
                {
                    arr[i] = new char[nSize];
                    arr[i] = Console.ReadLine().ToCharArray();
                }

                int G = 0;
                int R = 0;

                for (int i = 0; i < mSize; i++)
                {
                    for (int j = 0; j < nSize; j++)
                    {
                        if (arr[i][j] == '-' || arr[i][j] == '*')
                        {
                            R += 1;
                            Check(arr, i, j, ref G);
                        }
                    }
                }
                Console.WriteLine((1f * G /R).ToString("F"));
            }
        }

        static void Check(char[][] arr, int a, int b, ref int G)
        {
            if (arr[a][b] == 'v' || arr[a][b] == '#') return;
            if (arr[a][b] == '*') G += 1;

            arr[a][b] = 'v';
            Check(arr, a + 1, b, ref G);
            Check(arr, a - 1, b, ref G);
            Check(arr, a, b + 1, ref G);
            Check(arr, a, b - 1, ref G);
        }
    }
}
