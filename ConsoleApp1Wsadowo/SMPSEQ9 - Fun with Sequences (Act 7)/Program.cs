using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ9___Fun_with_Sequences__Act_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string[] sequenceS = Console.ReadLine().Split(' '); 
            string m = Console.ReadLine();
            string[] sequenceQ = Console.ReadLine().Split(' '); 
            int[] tablicaS = Array.ConvertAll<string, int>(sequenceS, int.Parse);
            int[] tablicaQ = Array.ConvertAll<string, int>(sequenceQ, int.Parse);
            int M = int.Parse(m);
            int N = int.Parse(n);
            double s = 0;
            double q = 0;
            foreach (int element in tablicaS) { s += element; }
            foreach (int element in tablicaQ) { q += element; }
            if ((q / M) < (s/N))
            {
                for (int nrS = 0; nrS < tablicaS.Length; nrS++)
                {
                    Console.Write(tablicaS[nrS]);
                    if (tablicaS.Length - nrS != 1) 
                    { 
                        Console.Write(' '); 
                    }
                }
            }
            else
            {
                for (int nrQ = 0; nrQ < tablicaQ.Length; nrQ++)
                {
                    Console.Write(tablicaQ[nrQ]);
                    if (tablicaQ.Length - nrQ != 1)
                    {
                        Console.Write(' ');
                    }

                }
            }
        }
    }
}
