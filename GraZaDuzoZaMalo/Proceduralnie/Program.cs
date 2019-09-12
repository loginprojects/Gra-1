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

        static void Main(string[] args)
        {
            Start();
            int x = Losuj();
            do
            {
                //wczytaj propozycję
                //oceń propozycję
            }
            while (true);
        }




        static void Main1(string[] args)
        {
            // 1. Komputer losuje liczbę z podanego zakresu
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // do usunięcia w Release
#endif
            Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Odgadnij ją.");

            Stopwatch czas = Stopwatch.StartNew();

            // powtarzaj wielokrotnie, aż odgadnie
            bool odgadniete = false;
            int licznik = 0;
            do
            {
                licznik++;
                // 2. Człowiek proponuje (odgaduje)
                Console.Write("Podaj swoją propozycję: ");
                string napis = Console.ReadLine();
                if (napis == "koniec")
                {
                    Console.WriteLine("Szkoda, że mnie opuszczasz.");
                    return;
                }

                int propozycja = 0;
                try
                {
                    propozycja = int.Parse(napis);
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

                // 3. Komputer ocenia propozycję
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
                    //odgadniete = true;
                    break;
                }
            }
            //while (!odgadniete); // while( propozycja != wylosowana )
            while (true);
            // koniec powtarzaj
            czas.Stop();


            // 4. Wypisz statystyki gry
            Console.WriteLine($"- liczba ruchów: {licznik}");
            Console.WriteLine($"- czas gry: {czas.Elapsed}");
        }
    }
}
