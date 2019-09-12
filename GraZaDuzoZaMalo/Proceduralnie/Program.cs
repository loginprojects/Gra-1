using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Proceduralnie
{
    class Program
    {
        static void Start()
        {
            Console.Clear();
            Console.WriteLine("Aplikacja GRA");
            Console.WriteLine("=============");
        }

        static int Losuj()
        {
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // do usunięcia w Release
#endif
            Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Odgadnij ją.");
            return wylosowana;
        }

        static int WczytajPropozycję()
        {
            int propozycja = 0;
            Console.Write("Podaj swoją propozycję: ");
            string napis = Console.ReadLine();
            while (true)
            {
                try
                {
                    propozycja = int.Parse(napis);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby.\n Spróbuj jeszcze raz");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przesadziłeś. Za duża liczba.");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Niezidentyfikowany wyjątek. Awaria");
                    Environment.Exit(1);
                }
            }
            return propozycja;
        }

        static bool Ocena(int wylosowana, int propozycja)
        {
            if (propozycja < wylosowana)
            {
                Console.WriteLine("Za mało");
            }
            else if (propozycja > wylosowana)
            {
                Console.WriteLine("Za dużo");
            }
            else
            {
                Console.WriteLine("Trafiłeś");
                return true;
            }
            return false;
        }


        static void Main(string[] args)
        {
            Start();
            int x = Losuj();
            do
            {
                int y = WczytajPropozycję();
                //oceń propozycję
            }
            while (true);
        }

    }
}