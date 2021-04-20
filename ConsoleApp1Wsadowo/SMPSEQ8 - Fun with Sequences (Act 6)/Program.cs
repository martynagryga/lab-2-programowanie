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
            int i = 0;
            int sumatablicaS = 0;
            int sumatablicaQ = 0;
           
            sumatablicaS += tablicaS[i];
            sumatablicaQ += tablicaQ[i];
            for (; i < sSequenceSplit.Length; ++i)
            {
                if (sumatablicaQ < sumatablicaS)
                {
                    Console.Write(tablicaS[i] + " ");
                    break;
                }
                else
                {
                    Console.Write(tablicaQ[i] + " ");
                    break;
                }
                    
                
            }
        }
    }
}
