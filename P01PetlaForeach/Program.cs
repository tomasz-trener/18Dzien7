using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01PetlaForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab = { "1", "5", "8", "9" };

            for (int i = 0; i < tab.Length; i= i+3)
            {
                string ityElement = tab[i];
            }

            foreach (string ityElement in tab)
            {
                Console.WriteLine(ityElement);
            }

            int k = 5;
            var k2 = 5;

            string s = "ala";
            var s2 = "ala";

            //  s2 = 4;

            List<StringBuilder[]> g = new List<StringBuilder[]>();
            var g2 = new List<StringBuilder[]>();

        }
    }
}
