using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_standardowe_bonusowe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animals = new List<string>();
            animals.Add("fox");
            animals.Add("horse");
            animals.Add("bird");
            animals.Add("lynx");
            animals.Add("spider");
            animals.Add("gecko");
            //for (int i = 0; i < animals.Count; i++)
            {
                //Console.WriteLine(animals[i]);
                
            }
            animals.RemoveAt(1);
            animals.RemoveAt(4);
            for (int j = 0; j < animals.Count; j++)
            {
                Console.WriteLine(animals[j]);
            }
        }
    }
}
