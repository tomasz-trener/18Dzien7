using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Dziedziczenie
{
    internal class Czlowiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        internal virtual void PrzedstawSie()
        {
            Console.WriteLine("(Czlowiek) nazywam sie" + Imie + " " + Nazwisko);
        }
    }
}
