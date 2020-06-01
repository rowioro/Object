using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Obiekty
{
    class Czlowiek
    {

        public string imie;
        public string nazwisko;

        public Czlowiek(string imieKonstruktora = "BRAK", string nazwiskoKonstruktora = "BRAK")
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }
        public void PrzedstawSie()
        {
            Console.WriteLine("Nazywam sie " + imie + " " + nazwisko);
        }

        ~Czlowiek()
        {
            Console.WriteLine("Jestem destruktorem, ktory tutaj posprzata.");
            Console.ReadKey();
        }
    }
}
