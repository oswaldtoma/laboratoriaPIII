using System;
using System.Collections.Generic;
using System.Text;

namespace zajecia3
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Funkcje funkcje = new Funkcje();

            float suma = 0;
            float wynik = 0;

            string ocenyString = funkcje.ocenySB().ToString();
            string[] ocenyArray = ocenyString.Split(new char[] {';'});

            float[] ocenyFloat = new float [ocenyArray.Length];

            for (int i = 0; i < ocenyArray.Length-1; i++)
            {
                ocenyFloat[i] = float.Parse(ocenyArray[i]);
            }
            
            foreach (float ocena in ocenyFloat)
            {
                suma += ocena;
            }

            wynik = funkcje.ObliczSrednia(suma, ocenyFloat.Length);
            
            Console.WriteLine(wynik);

        }
    }
}