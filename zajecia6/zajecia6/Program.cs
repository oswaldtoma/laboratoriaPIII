using System;
using System.Linq;
using System.Collections.Generic;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace zajecia6
{
    public class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;

        public Osoba(int id, string imie, string nazwisko)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {   
//            List<int> lista = Enumerable.Range(100, 150).ToList();
//            List<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();
//
//            const int elementyNaStronie = 25;
//            const int nrStrony = 2;
//            List<int> strona = lista.Skip(elementyNaStronie * (nrStrony - 1)).Take(elementyNaStronie).ToList();
//            
//            double srednia = lista.Sum();
//            Console.WriteLine(srednia);
//
//            List<Osoba> osoby = Enumerable.Range(1, 50)
//                .Select(x => new Osoba()
//                {
//                    id = x,
//                    imie = x.ToString(),
//                    nazwisko = "aaa"
//                }).ToList();
//            osoby[30].nazwisko = "bbb";
//            foreach (var item in osoby)
//            {
//                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
//            }

//            IEnumerable<int> ids = osoby.Select(x => x.id);
//            foreach (var item in ids)
//            {
//                Console.WriteLine(item);
//            }
//            osoby.Select(x => x.nazwisko).Distinct().ToList().ForEach(x => Console.WriteLine(x));
//            foreach (var item in nazwiska)
//            {
//                Console.WriteLine(item);
//            }
//
//            int pierwszy = lista.FirstOrDefault(x=>x % 300 == 0);
//            Console.WriteLine(pierwszy);
//
            var RandomIntGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            var RandomNameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var RandomLastNameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
//
//            
            Osoba random = new Osoba(
                RandomIntGenerator.Generate().Value,
                RandomNameGenerator.Generate(), 
                RandomLastNameGenerator.Generate()
                );
//            
//            Console.WriteLine($"{random.id}: {random.imie} {random.nazwisko}");

            Osoba[] osoby = new Osoba[100];

            for (int i = 0; i < osoby.Length; i++)
            {
                osoby[i] = new Osoba(
                    RandomIntGenerator.Generate().Value,
                    RandomNameGenerator.Generate(), 
                    RandomLastNameGenerator.Generate()
                );
            }

            List<Osoba> posortowane = osoby.OrderBy(x => x.nazwisko).ThenBy(x => x.imie).ToList();
            foreach (var item in posortowane)
            {
                Console.WriteLine($"{item.nazwisko} {item.imie}");
            }
        }
    }
}