using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace kolokwium_25._01
{
    class Program
    {
        static void Kup(string nzw)
        {
            Dostawca1 dost1 = new Dostawca1();
            dost1.nazwaDostawcy = "Dostawca 1";
            
            Dostawca2 dost2 = new Dostawca2();
            dost2.nazwaDostawcy = "Dostawca 2";

            dost1.Zamow(dost1.Wyszukaj(nzw));
            dost2.Zamow(dost2.Wyszukaj(nzw));
            
        }
        
        static void Main(string[] args)
        {
            var random = new Random();
            var przelewy = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                przelewy.Add(random.Next(-1000, 1000));
            }

            var min = przelewy.Min();
            var max = przelewy.Max();
            var avg = przelewy.Average();
            var suma = przelewy.Sum();
            var przUjemne = przelewy.Where(x => x < 0).Count();
            var przDodatnie = przelewy.Where(x => x > 0).Count();

            Console.WriteLine($"Najmniejsza kwota: {min}, Najwieksza kwota: {max} \n" +
                              $"Srednia kwota: {avg}, Suma: {suma} \n" +
                              $"Przelewy ujemne: {przUjemne}, Przelewy dodatnie: {przDodatnie}");
            
            
            
            Telefon nokia3310 = new Telefon();
            nokia3310.Dzwon("555444333");
            
            Smartfon XPhone = new Smartfon();
            XPhone.Dzwon("123123123");
            XPhone.LadujStroneWWW("http://google.pl");
        }
    }
}