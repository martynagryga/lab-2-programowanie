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
            string n = Console.ReadLine();
            string sSequences = Console.ReadLine();
            int a = int.Parse(n);
            string[] sSequencesSplit = sSequences.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] sequences = Array.ConvertAll<string, int>(sSequencesSplit, int.Parse); 
            int position = 0; 
            int wynik = 0;

            for (int i = 0; i < a - 1; i++) 
            {
                if (sequences[i] > sequences[i + 1])
                {
                    position++;
                }
                else if (position == 0)
                {
                    break;
                }
                else
                {
                    position++;
                    wynik++;
                    break;
                }
            }
            for (int j = 0 + position; j < a - 1; j++) 
            {
                if (sequences[j] < sequences[j + 1])
                {
                    position++;
                }
                else
                {
                    position++;
                    break;
                }
            }
            if (position == a - 1 && wynik == 1) 
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

