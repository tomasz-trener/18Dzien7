using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ZadanieDziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raport[] pliki = new Raport[3];
            pliki[0] = new PlikCSV() { Tresc = "ala ma kota", Sciezka = @"c:\dane\pliki\p1" };
            pliki[1] = new PlikSQL() { Tresc = "ala ma kota", Sciezka = @"c:\dane\pliki\p2" };
            pliki[2] = new PlikHTML() { Tresc = "ala ma kota", Sciezka = @"c:\dane\pliki\p3" };

            foreach (var p in pliki)
                p.Zapisz();


           // Raport r = new Raport();

            Raport r2 = new PlikHTML();
        }
    }
}
