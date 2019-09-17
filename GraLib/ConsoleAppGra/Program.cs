using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraLib;

namespace ConsoleAppGra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj od: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj do: ");
            int y = int.Parse(Console.ReadLine());

            ModelGry gra = new ModelGry(x, y);
            int propozycja;
            Console.WriteLine("Podaj propozycję: ");
            propozycja= int.Parse(Console.ReadLine());
            Console.WriteLine(gra.Ocena(propozycja));

            Console.WriteLine("Podaj propozycję: ");
            propozycja = int.Parse(Console.ReadLine());
            Console.WriteLine(gra.Ocena(propozycja));

            Console.WriteLine("Podaj propozycję: ");
            propozycja = int.Parse(Console.ReadLine());
            Console.WriteLine(gra.Ocena(propozycja));

            //Console.WriteLine(gra.Historia ); źle?

            int licznik = 1;
            foreach (var r in gra.Historia)
            {
                //Console.WriteLine(r);
                Console.WriteLine($"{licznik}. {r.Propozycja} --> {r.Odpowiedz}  ({r.Czas})");
                licznik++;
            }

            if(gra.StanGry != ModelGry.Stan.Trwa)
            Console.WriteLine($"wylosowana = {gra.Wylosowana}");
        }
    }
}


//https://github.com/wsei-wdp/zgadywanka-projekt/tree/master/demo