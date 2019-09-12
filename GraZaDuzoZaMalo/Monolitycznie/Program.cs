using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Console.WriteLine("Wylosowałem liczbę od 1 do 100. Odgadnij ją!");
            Stopwatch czas = Stopwatch.StartNew();

            // ----powtarzaj do odgadniecia
            //bool odgadniete = false;
            int licznik = 0;
            do
            {
                licznik++;
                //2. Człowiek proponuje liczbę
                Console.Write("Podaj swoją propozycję:  ");
                
                string napis = Console.ReadLine();
                if (napis=="koniec")
                {
                    Console.WriteLine("bye");
                    return;
                }
                int propozycja=0;
                try
                {
                    propozycja = int.Parse(napis);
                }
                catch (FormatException){
                    Console.WriteLine("Nie podano liczby.\nSpróbuj jeszcze raz ");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Za duża liczba.");
                    continue;
                }
                catch (Exception){
                    Console.WriteLine("???");
                    Environment.Exit(1);

                }
                //3. Komputer ocenia

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
                    Console.WriteLine("Trafiłeś!");
                    //odgadniete = true; //wartownik, flaga
                    break;
                }
            } //while (!odgadniete); lub while(propozycja!=wylosowana)
            while (true);
            
            //----koniec powtarzania

czas.Stop();
            //4. Wypisz statystyki gry

            Console.WriteLine($"* liczba ruchów: {licznik}");
            Console.WriteLine($"* czas: {czas.Elapsed}");


        }
    }
}
