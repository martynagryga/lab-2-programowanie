using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ3_sequence 
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
                bool found = false;
                for (int j = 0; j < qSequenceSplit.Length; ++j)
                {
                    if (sSequenceSplit[i] == qSequenceSplit[j])
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.Write(sSequenceSplit[i] + " ");
                }
            }

        }
    }
}
