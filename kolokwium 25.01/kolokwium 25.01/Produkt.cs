using System.Globalization;

namespace kolokwium_25._01
{
    public class Produkt
    {
        public Produkt(string nazwa, int ilosc)
        {
            this.nazwa = nazwa;
            this.ilosc = ilosc;
        }

        public string nazwa { get; set; }
        public int ilosc { get; set; }
    }
}