using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyfry_LED
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] zero = new char[,] { { ' ', '_', ' ' }, { '|', ' ', '|' }, { '|', '_', '|' } };

            char[,] one = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };

            char[,] two = new char[,] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { '|', '_', ' ' } };

            char[,] three = new char[,] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { ' ', '_', '|' } };

            char[,] four = new char[,] { { ' ', ' ', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };

            char[,] five = new char[,] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { ' ', '_', '|' } };

            char[,] six = new char[,] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { '|', '_', '|' } };

            char[,] seven = new char[,] { { ' ', '_', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };

            char[,] eight = new char[,] { { ' ', '_', ' ' }, { '|', '_', '|' }, { '|', '_', '|' } };

            char[,] nine = new char[,] { { ' ', '_', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };

            string number = Console.ReadLine();
            string[] digits = number.Split(' ');

            char[,] wynik = new char[3, digits[0].Length * 3];

            for (int i = 0; i < digits[0].Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (digits[0][i] == '0')
                        {
                            wynik[j, 3 * i + k] = zero[j, k];
                        }
                        else if (digits[0][i] == '1')
                        {
                            wynik[j, 3 * i + k] = one[j, k];
                        }
                        else if (digits[0][i] == '2')
                        {
                            wynik[j, 3 * i + k] = two[j, k];
                        }
                        else if (digits[0][i] == '3')
                        {
                            wynik[j, 3 * i + k] = three[j, k];
                        }
                        else if (digits[0][i] == '4')
                        {
                            wynik[j, 3 * i + k] = four[j, k];
                        }
                        else if (digits[0][i] == '5')
                        {
                            wynik[j, 3 * i + k] = five[j, k];
                        }
                        else if (digits[0][i] == '6')
                        {
                            wynik[j, 3 * i + k] = six[j, k];
                        }
                        else if (digits[0][i] == '7')
                        {
                            wynik[j, 3 * i + k] = seven[j, k];
                        }
                        else if (digits[0][i] == '8')
                        {
                            wynik[j, 3 * i + k] = eight[j, k];
                        }
                        else if (digits[0][i] == '9')
                        {
                            wynik[j, 3 * i + k] = nine[j, k];
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < digits[0].Length * 3; j++)
                {
                    Console.Write(wynik[i, j]);
                }
                Console.WriteLine();
            }
        
        }
    }
}
