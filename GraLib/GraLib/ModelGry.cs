using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLib
{
    public partial class ModelGry
    {
        private int wylosowana; // jeśli by było read only to nie można zmienić poza konstruktorem
        public int ZakresOd { get; private set; } //properties get publiczny, set prywatny- read only
        public int ZakresDo { get; private set; } //properties

        //Stan gry
        public enum Stan { Trwa, Poddana, Odgadnieta }
        public Stan StanGry { get; private set; }

        //Historia
        public List<Ruch> /*notocja typu generycznego*/ Historia { get; private set; } //sama deklaracja- brak listy przed utworzeniem konstruktora

        //konstruktor nazwany jak nazwa klasy
        public ModelGry(int zakresOd = 1, int zakresDo = 100)
        {
            ZakresOd = Math.Min(zakresOd, zakresDo);
            ZakresDo = Math.Max(zakresOd, zakresDo);
            Random los = new Random();
            wylosowana = los.Next(ZakresOd, ZakresDo + 1);
            StanGry = Stan.Trwa;
            Historia = new List<Ruch>(); //konstruktor Ad. 20
        }

        //Metody
        public enum Odp { ZaMalo = -1, Trafione = 0, ZaDuzo = 1 }; // po = system kodowania

        public Odp Ocena(int propozycja)
        {
            if (propozycja < wylosowana)
            {
                Historia.Add(new Ruch(propozycja, Odp.ZaMalo));
                /* - to samo ale z niepotrzebną zmienną:
                Ruch r =new Ruch(propozycja, Odp.ZaMalo);
                Historia.Add(r);
                */
                return Odp.ZaMalo;
            }
            else if (propozycja > wylosowana)
            {
                Historia.Add(new Ruch(propozycja, Odp.ZaDuzo));
                return Odp.ZaDuzo;
            }
            else
            {
                StanGry = Stan.Odgadnieta;
                Historia.Add(new Ruch(propozycja, Odp.Trafione));
                return Odp.Trafione;
            }
        }

        public void Poddaj()
        {
            StanGry = Stan.Poddana;
        }

        public int Wylosowana
        {
            get
            {
                if (StanGry == Stan.Poddana || StanGry == Stan.Odgadnieta)
                    return wylosowana;
                else
                    throw new NotSupportedException("Ni ma!");
            }
        }
























    }
}
