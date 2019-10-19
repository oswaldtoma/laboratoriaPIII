using System;
using System.Diagnostics;

namespace zajecia4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[][] tablica =
            {
                new[]{1, 2, 3, 4},
                new[]{1, 2},
                new[]{1},
                new[]{1, 2, 3, 4, 5, 6, 7},
            };

            int[][] newTablica = new int[tablica.Length][];

            bool state = false;
            klasaKopiujaca.skopiujTablice(tablica, newTablica, ref state);
            Console.WriteLine(state);
        }
    }
}