using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1interaktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");
            Console.Write("Podaj swoje imię :");
            string imie; //deklaracja
            imie = Console.ReadLine(); //przypisanie

            Console.Write("Podaj swoje nazwisko :");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj, " + imie + " " + nazwisko + "!"); //sposób 1 - konkatenacja
            string napis = string.Format("Witaj, {0} {1}!" , imie, nazwisko);
            Console.WriteLine(napis);



             
        }
    }
}
