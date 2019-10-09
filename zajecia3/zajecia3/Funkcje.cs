using System;
using System.Text;

namespace zajecia3
{
    public class Funkcje
    {
        public float ObliczSrednia(float suma, int iloscElementow)
        {
            return suma / (float)iloscElementow;
        }

        public StringBuilder ocenySB()
        {
            Console.WriteLine("Podaj oceny:");
            var sb = new StringBuilder();
            string odpowiedz = " ";

            while (odpowiedz != string.Empty)
            {
                odpowiedz = Console.ReadLine();
                if(odpowiedz == String.Empty)
                    sb.Append(odpowiedz + ",");
            } 
            Console.WriteLine(sb.ToString());

            return sb;
        }
    }
}