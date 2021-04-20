using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ7___Fun_with_Sequences__Act_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstline = Console.ReadLine();
            string sSequence = Console.ReadLine();
            string[] firstlineSplit = firstline.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] sSequenceSplit = sSequence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = Int32.Parse(firstlineSplit[0]);
            int i = 1;
            for (; i < n; ++i)
            {
                if (sSequence[i] >= sSequence[i - 1])
                {
                    break;
                }
            }
            ++i;
            for (; i < n; ++i)
            {
                if (sSequence[i] <= sSequence[i - 1])
                {
                    Console.Write("NO");
                    return;
                }
            }
            Console.Write("YES");
        }
    }
}
