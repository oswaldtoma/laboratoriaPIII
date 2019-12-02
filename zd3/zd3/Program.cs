using System;

namespace zd3
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            
            CUczen jankowalski = new CUczen("Jan", "Kowalski");
            
            jankowalski.wystawOcene(COcena.TOceny.matematyka.ToString(), 3.0, 2);
            jankowalski.wystawOcene(COcena.TOceny.matematyka.ToString(), 3.5, 5);
            jankowalski.wystawOcene(COcena.TOceny.matematyka.ToString(), 2.0, 3);
            jankowalski.wystawOcene(COcena.TOceny.matematyka.ToString(), 4.0, 1);
            
            Console.WriteLine(jankowalski.sredniaWazona());
        }
    }
}