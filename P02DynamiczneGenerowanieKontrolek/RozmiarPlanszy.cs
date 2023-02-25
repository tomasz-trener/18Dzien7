using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02DynamiczneGenerowanieKontrolek
{
    internal class RozmiarPlanszy
    {
        public int Rozmiar;

        public RozmiarPlanszy(int rozmiar)
        {
            Rozmiar = rozmiar;
        }
        public string Text 
        { 
            get
            {
                return Rozmiar + " x " + Rozmiar;
            } 
        }
    }
}
