using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal abstract class Raport
    {
        public string Tresc { get; set; }
        public int Rozmiar { get; set; }
        public string Autor { get; set; }
        public string Sciezka { get; set; }

        public string Rozszerzenie { get; set; }

        public virtual void Zapisz() {
            File.WriteAllText(Sciezka + Rozszerzenie, Tresc);
        }
    }
}
