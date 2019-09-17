using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLib
{
    public class ModelGry
    {
        private int wylosowana;
        public int ZakresOd { get; private set; }
        public int ZakresDo { get; private set; }

        public ModelGry(int zakresOd, int zakresDo)
        {
            ZakresOd = zakresOd;
            ZakresDo = zakresDo;
            Random los = new Random();
            wylosowana = los.Next(ZakresOd, ZakresDo + 1);
        }

    }
}
