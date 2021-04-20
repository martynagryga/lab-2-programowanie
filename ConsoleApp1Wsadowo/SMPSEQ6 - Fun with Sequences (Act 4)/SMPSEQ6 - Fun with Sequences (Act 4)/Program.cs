using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMPSEQ6___Fun_with_Sequences__Act_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstline = Console.ReadLine();
            string sSequence = Console.ReadLine();            
            string qSequence = Console.ReadLine();
            string[] firstlineSplit = firstline.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);            
            string[] sSequenceSplit = sSequence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] qSequenceSplit = qSequence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = Int32.Parse(firstlineSplit[0]);
            int x = Int32.Parse(firstlineSplit[1]);            
            if (x >= 0)
            {
                for (int i = 0; i < n; ++i)
                {
                    for (int y = -x; y<=x; ++y)
                    {
                        if(i+y<n && i+y>=0 && sSequenceSplit[i] == qSequenceSplit[i+y] )
                        {             
                            Console.Write($"{i+1}" + " ");
                            break;
                        }
                    }                                                   
                   
                }
            }
            else
            {
                Console.Write("error");
            }
        }
    }
}
