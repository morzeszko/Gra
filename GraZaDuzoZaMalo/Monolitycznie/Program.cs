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
            //1. Komputer losuje liczbę z podanego zakresu
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana);
#endif
            // ----powtarzaj do odgadniecia
            //2. Człowiek proponuje liczbę

            
            //3. Komputer ocenia
            //----koniec powtarzania
            //4. Wypisz statystyki gry
        }
    }
}
