using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Dziedziczenie
{
    internal class Czlowiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        internal void PrzedstawSie()
        {
            Console.WriteLine("nazywam sie" + Imie + " " + Nazwisko);
        }
    }
}
