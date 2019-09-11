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

            // 1.komputer losuje liczbe z podanego zakresu
            // 1 do 100 
            Random los = new Random();
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana); // do usuniecia w release
#endif

            // 2.czlowiek porponuje/ odgaduje 
            // 3. komputer ocneia propozycje
            //  koniec powtarzran

            //  4. wypisz staty



        }
    }
}
