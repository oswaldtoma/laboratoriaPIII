using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace kolokwium_9._11
{
    //GRUPA B
    internal class Program
    {
        public static void Main(string[] args)
        {
            CWarunekModulo warunek = new CWarunekModulo();
            CDanePracownikow dane = new CDanePracownikow();
            
            Console.WriteLine(CStandaryzacjaWartosci.standaryzacjaWartosci(70));

            int[] tablica = {1, 2, 3, 45, 16};
            warunek.warunekModulo(tablica);

            int[][] dzialy =
            {
                new[]{1,2,9,10},
                new[]{3,4,5,21}
            };
            
            dane.danePracownicze(dzialy);
        }
    }
}