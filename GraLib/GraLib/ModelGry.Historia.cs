using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraLib
{
    public partial class ModelGry
    {
        public class Ruch // klasa wewn. inner class
        {
            public DateTime Czas { get; private set; }
            public int Propozycja { get; private set; }
            public Odp Odpowiedz { get; private set; }

            //konstruktor
            public Ruch (int propozycja, Odp odpowiedz)
            {
                Czas = DateTime.Now; //Now to properties typu datetime
                Propozycja = propozycja;
                Odpowiedz = odpowiedz;
            }

            //Metoda ToString

            public override string ToString() => /* notacja funkcyjna lambda*/ $"{Czas} {Propozycja} {Odpowiedz}";
            


        }


    }
}
