using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class PlikHTML : Raport
    {
        private const string szablob = "<HTML><BODY><P>{0}</P></BODY></HTML>";

        public PlikHTML()
        {
            Rozszerzenie = ".html";
        }

        public override void Zapisz()
        {
            Tresc = string.Format(szablob, Tresc);
            base.Zapisz();
        }
    }
}
