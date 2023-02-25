using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object o = new object();

            Zawodnik z = new Zawodnik();
            z.Imie = "jan";
            z.Nazwisko = "kowalski";


            Czlowiek c = new Czlowiek();

            Czlowiek c2 = new Zawodnik();

            // c2 jest zawodnikiem widzianym jako człowiek
            // 

            // Zawodnik z2 = new Czlowiek();

            //-----------------------------

            Zawodnik z1 = new Zawodnik() { Imie = "jan", Nazwisko = "kowalski", LiczbaMedali = 4 };
            Zawodnik z2 = new Zawodnik() { Imie = "adam", Nazwisko = "malysz", LiczbaMedali = 5 };

            Programista p1 = new Programista() { Imie = "marcin", Nazwisko = "marcinkiewicz", LiczbaMonitorow = 4 };
            Programista p2 = new Programista() { Imie = "ola", Nazwisko = "nowak", LiczbaMonitorow = 5 };

            List<Czlowiek> lista = new List<Czlowiek>();
            lista.Add(z1);
            lista.Add(z2);
            lista.Add(p1);
            lista.Add(p2);

            foreach (Czlowiek item in lista)
            {
                item.PrzedstawSie();
                //Console.Write("nazywam sie" + item.Imie + " " + item.Nazwisko);

                if (item is Zawodnik)
                {
                    Console.WriteLine(" mam medali" + ((Zawodnik)item).LiczbaMedali);
                }

                if (item is Programista)
                {
                    Console.WriteLine(" mam monitorow" + ((Programista)item).LiczbaMonitorow);
                }
            }
            Console.ReadKey();


        }
    }
}
