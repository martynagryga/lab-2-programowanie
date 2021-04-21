using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ8___Fun_with_Sequences__Act_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string sSequence = Console.ReadLine();
            string m = Console.ReadLine();
            string qSequence = Console.ReadLine();
            string[] sSequenceSplit = sSequence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] qSequenceSplit = qSequence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] tablicaS = Array.ConvertAll<string, int>(sSequence.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int[] tablicaQ = Array.ConvertAll<string, int>(qSequence.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int S = 0;
            int Q = 0;
            foreach (int element in tablicaS) { S += element; }
            foreach (int element in tablicaQ) { Q += element; }
            if (Q < S)
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
