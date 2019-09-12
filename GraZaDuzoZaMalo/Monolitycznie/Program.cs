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

            // 1.komputer losuje liczbe z podanego zakresu
            // 1 do 100 
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // do usuniecia w release
#endif
            Console.WriteLine("Wylosowałem liczbę z zakresu od 1 do 100. Odgadnij ją");

            Stopwatch czas = Stopwatch.StartNew();

          

            //powtarzaj
            bool odgadniete = false;
            int licznik = 0;

            do
            {
                licznik++;

                // 2.czlowiek porponuje/ odgaduje 

                Console.WriteLine("Podaj swoją propozycję: ");
                string napis = Console.ReadLine();
                //zakonczenie
                if(napis == "koniec")
                {

                    Console.WriteLine("Szkoda. Że mnie opuszczasz.");
                    return;
                }

                //sprawdzanie wyjatkow
                int propozycja = 0;
                try
                {
                    propozycja = int.Parse(napis); //zgłASZA wyjatek
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby," + " spróbuj jeszcze raz");
                    continue;

                }

                catch (OverflowException)
                {
                    Console.WriteLine("Przesadziłeś, za duża liczba.");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("Niezidentyfikowany wyjątek. Awaria");
                    Environment.Exit(1);
                }

                // 3. komputer ocneia propozycje

                if (propozycja < wylosowana)
                {

                    Console.WriteLine("Za mało ");


                }
                else if (propozycja > wylosowana)
                {
                    Console.WriteLine("Za dużo");

                }
               
                
                else
                {

                    Console.WriteLine("Brawo, trafiłeś");
                    // odgadniete = true;
                    break;
                }
            }
            // while (! odgadniete);

            while (true);

            czas.Stop();



            //  koniec powtarzran

            //  4. wypisz staty
            Console.WriteLine($"* liczba ruchów: {licznik}");
            Console.WriteLine($"* czas gry: {czas.Elapsed}");

        }
    }
}
