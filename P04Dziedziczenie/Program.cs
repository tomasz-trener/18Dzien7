using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zawodnik z1 = new Zawodnik() { Imie = "jan", Nazwisko = "kowalski", LiczbaMedali = 4 };
            Zawodnik z2 = new Zawodnik() { Imie = "adam", Nazwisko = "malysz", LiczbaMedali = 5 };

            Programista p1 = new Programista() { Imie = "marcin", Nazwisko = "marcinkiewicz", LiczbaMonitorow = 4 };
            Programista p2 = new Programista() { Imie = "ola", Nazwisko = "nowak", LiczbaMonitorow = 5 };

            Czlowiek c = new Czlowiek() { Imie = "alan", Nazwisko = "kowal" };





            List<Czlowiek> lista = new List<Czlowiek>();
            lista.Add(c);
            lista.Add(z1);
            lista.Add(z2);
            lista.Add(p1);
            lista.Add(p2);

            foreach (Czlowiek item in lista)
            {
                item.PrzedstawSie();
            }
            Console.ReadKey();


            Czlowiek cx = (Czlowiek)new Zawodnik();

            Zawodnik z = (Zawodnik)cx;


            object o = z;
            object o2 = new Programista();

            Programista p2x = (Programista)o2;
        }
    }
}
