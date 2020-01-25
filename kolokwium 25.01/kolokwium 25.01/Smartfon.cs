using System;

namespace kolokwium_25._01
{
    public class Smartfon : Telefon
    {
        public void LadujStroneWWW(string adresStr)
        {
            Console.WriteLine($"Trwa ladowanie strony: {adresStr}");
        }
    }
}