﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Zadania_petle
{
    class Program
    {
        static void Main()
        {
            //wczytywanie i parsowanie danych wejściowych
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(' '), int.Parse);
            int a = Math.Min(dane[0], dane[1]);
            int b = Math.Max(dane[0], dane[1]);
            int c = dane[2];
            List<int> elements = new List<int>();
            if (c > 0)
            {
                for (int i = a+1; i < b; ++i)
                {
                    if (i % c == 0)
                    {
                        elements.Add(i);
                    }
                }
            }
            if (elements.Count > 10)
            {
                Console.Write("{0}, {1}, {2}, ..., {3}, {4}", elements[0], elements[1], elements[2], elements[elements.Count - 2], elements[elements.Count - 1]);
            }
            else if (elements.Count > 0)
            {
                for (int i = 0; i < elements.Count - 1; ++i)
                {
                    Console.Write("{0}, ", elements[i]);
                }
                Console.Write(elements[elements.Count - 1]);
            }
            else
            {
                Console.Write("empty");
            }
        }
    }
}