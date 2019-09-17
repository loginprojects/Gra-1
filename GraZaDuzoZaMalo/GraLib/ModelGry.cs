using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLib
{
    public class ModelGry
    {
        readonly private int wylosowana; // readonly oznacza, że nie można zmienić wartości poza konstruktorem
        public int ZakresOd { get; private set; }
        public int ZakresDo { get; private set; }
        public enum Stan { Trwa, Poddana, Odgadnieta }
        public Stan StanGry { get; private set; }


        // konstruktor
        public ModelGry(int zakresOd = 1, int zakresDo = 100)
        {
            ZakresOd = Math.Min( zakresOd, zakresDo );
            ZakresDo = Math.Max( zakresOd, zakresDo );
            Random los = new Random();
            wylosowana = los.Next(ZakresOd, ZakresDo + 1);
            StanGry = Stan.Trwa;
        }


        // Metody
        public enum Odp { ZaMalo = -1, Trafione = 0, ZaDuzo = 1 };

        public Odp Ocena(int propozycja)
        {
            if (propozycja < wylosowana)
                return Odp.ZaMalo;
            else if (propozycja > wylosowana)
                return Odp.ZaDuzo;
            else
            {
                StanGry = Stan.Odgadnieta;
                return Odp.Trafione;
            }
        }

        public void Poddaj()
        {
            StanGry = Stan.Poddana;
        }

        int Wylosowana
        {
            get
            {
                if (StanGry == Stan.Poddana || StanGry == Stan.Odgadnieta)
                    return wylosowana;
                else
                    throw new NotSupportedException("nie wolno teraz Ci tej warotości udostępnić");
            }
        }

    }
}
