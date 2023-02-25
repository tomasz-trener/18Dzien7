using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class PlikSQL : Raport
    {

        public PlikSQL()
        {
            Rozszerzenie = ".sql";
        }
        public override void Zapisz()
        {
            Tresc = "SELECT " + Tresc + " FROM dane";
            base.Zapisz();
        }
    }
}
