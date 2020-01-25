using System;
using System.Collections.Generic;
using System.Linq;

namespace kolokwium_25._01
{
    public class Dostawca1 : IDostawca
    {
        public string nazwaDostawcy { get; set; }

        List<Produkt> produkty = new List<Produkt>
        {
            new Produkt("Samochod", 2),
            new Produkt("Telefon", 3)
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