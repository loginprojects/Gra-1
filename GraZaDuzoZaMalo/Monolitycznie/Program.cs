using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Komputer losuje liczbę z podanego zakresu
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // do usunięcia w Release
#endif
            // powtarzaj wielokrotnie, aż odgadnie
            // 2. Człowiek proponuje (odgaduje)

            // 3. Kompuetra ocenia propozycję
            // koniec powtarzaj

            // 4. Wypisz statystyki gry
        }
    }
}
