using System;

namespace zajecia2
{
    class Program
    {
        static int iloscProduktow = 0;
        static void UnikalnaNazwa(string nazwaProduktu)
        {
            iloscProduktow++;
            Console.WriteLine("Produkt [" + nazwaProduktu + "] " + iloscProduktow);
        }
        static void Main(string[] args)
        {
            bool escape = false;
            string odpowiedz = "";
            while(odpowiedz != "x")
            {
                if (iloscProduktow >= 3) break;
                Console.WriteLine("\nPodaj nazwe produktu:\n");
                odpowiedz = Console.ReadLine();
                switch(odpowiedz)
                {
                    case "1":
                    case "2":
                    case "3":
                        UnikalnaNazwa(odpowiedz);
                        break;
                    case "x":
                        break;
                }
            }
        }
    }
}