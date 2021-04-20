﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIGNUM___Digital_LED_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,,] print = new char[,,]
             {
            { { ' ', '_', ' ' }, { '|', ' ', '|' }, { '|', '_', '|' } },

            { { ' ', ' ', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } },

            { { ' ', '_', ' ' }, { ' ', '_', '|' }, { '|', '_', ' ' } },

            { { ' ', '_', ' ' }, { ' ', '_', '|' }, { ' ', '_', '|' } },

            { { ' ', ' ', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } },

            { { ' ', '_', ' ' }, { '|', '_', ' ' }, { ' ', '_', '|' } },

            { { ' ', '_', ' ' }, { '|', '_', ' ' }, { '|', '_', '|' } },

            { { ' ', '_', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } },

            { { ' ', '_', ' ' }, { '|', '_', '|' }, { '|', '_', '|' } },

            { { ' ', '_', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } }
             };


            while (true)
            {
                string fl = Console.ReadLine();
                if (string.IsNullOrEmpty(fl))
                {
                    break;
                }
                string sl = Console.ReadLine();
                string tl = Console.ReadLine();
                int wynik = 0;


                if (fl.Length == sl.Length && sl.Length == tl.Length)
                {
                    if (fl.Length % 3 == 0)
                    {
                        for (int i = 0; i < fl.Length; i += 3)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                if (fl[i] == print[j, 0, 0] && sl[i] == print[j, 1, 0] && tl[i] == print[j, 2, 0] && fl[i + 1] == print[j, 0, 1] && sl[i + 1] == print[j, 1, 1] && tl[i + 1] == print[j, 2, 1] && fl[i + 2] == print[j, 0, 2] && sl[i + 2] == print[j, 1, 2] && tl[i + 2] == print[j, 2, 2])
                                {
                                    wynik *= 10;
                                    wynik += j;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(wynik);
                    }
                }
            }

        }
    }
}
