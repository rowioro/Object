using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Obiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek osoba1 = new Czlowiek("Alicja","Strugala");
            osoba1.PrzedstawSie();

            Console.ReadKey();
        }
    }

}
