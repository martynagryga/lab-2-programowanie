using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKS___RK_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            string dane = Console.ReadLine();
            int n = int.Parse(dane.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0]);
            int c = int.Parse(dane.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);

            dane = Console.ReadLine();
            List<int> liczby = new List<int>(Array.ConvertAll(dane.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries), int.Parse));

            var countedLiczby = new Dictionary<int, int>();
            for (int i = 0; i < liczby.Count; i++)
            {
                if (!countedLiczby.ContainsKey(liczby[i]))
                {
                    countedLiczby.Add(liczby[i], liczby.FindAll(x => x == liczby[i]).Count);
                }
            }

            foreach (KeyValuePair<int, int> item in countedLiczby.OrderByDescending(x => x.Value))
            {
                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
    
