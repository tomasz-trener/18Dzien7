using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class PlikCSV : Raport
    {
        public PlikCSV()
        {
            Rozszerzenie = ".csv";
        }

        public override void Zapisz()
        {
            Tresc = Tresc.Replace(" ", ";");
            base.Zapisz();
        }
    }
}
