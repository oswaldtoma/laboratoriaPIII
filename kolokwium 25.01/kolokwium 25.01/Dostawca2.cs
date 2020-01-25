using System;
using System.Collections.Generic;
using System.Linq;

namespace kolokwium_25._01
{
    public class Dostawca2 : IDostawca
    {
        public string nazwaDostawcy { get; set; }

        List<Produkt> produkty = new List<Produkt>
        {
            new Produkt("Papier", 2),
            new Produkt("Tramwaj", 3)
        };

        public Produkt Wyszukaj(string naz)
        {
            Produkt temp = new Produkt("", 0);
            foreach (var item in produkty)
            {
                if (item.nazwa == naz)
                    temp = item;
            }

            return temp;
        }

        public void Zamow(Produkt produkt)
        {
            Console.WriteLine($"Zamowiono produkt o nazwie: {produkt.nazwa} u dostawcy: {nazwaDostawcy}");
        }
    }
}