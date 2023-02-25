using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Zawodnik : Czlowiek
    {
        public int LiczbaMedali { get; set; }

        internal override void PrzedstawSie()
        {
            Console.WriteLine("(Zawodnik) nazywam sie" + Imie + " " + Nazwisko + " i mam medali: "+ LiczbaMedali);
        }
    }
}
