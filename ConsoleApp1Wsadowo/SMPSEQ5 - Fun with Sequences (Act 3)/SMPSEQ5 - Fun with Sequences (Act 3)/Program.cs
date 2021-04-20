using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ5___Fun_with_Sequences__Act_3_
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
            for (int i = 0; i < sSequenceSplit.Length; ++i)
            {
                if (i < qSequenceSplit.Length && sSequenceSplit[i] == qSequenceSplit[i])
                    {
                        Console.Write($" {i + 1}" + " ");
                    }
                
            }
        }
    }
}
