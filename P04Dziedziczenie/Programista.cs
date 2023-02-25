using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Programista : Czlowiek
    {
        public int LiczbaMonitorow { get; set; }

        public Programista()
        {

        }

        internal override void PrzedstawSie()
        {
            Console.WriteLine("(Programista) nazywam sie" + Imie + " " + Nazwisko + " i mam medali: " + LiczbaMonitorow);
        }
    }
}
