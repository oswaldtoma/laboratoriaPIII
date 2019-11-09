using System;

namespace kolokwium_9._11
{
    public class CDanePracownikow
    {
        public void danePracownicze(in int[][] tablicaDzialow)
        {
            int najnowszy = new int();
            int dzialNajnowszego = new int();
            
            int najwiecejPracownikow = new int();

            for (int i = 0; i < tablicaDzialow.Length; i++)
            {
                if (tablicaDzialow[i].Length > najwiecejPracownikow)
                    najwiecejPracownikow = i;
                
                Console.Write("Dzial nr " + i + ": " +
                              "Ilość pracowników: " + tablicaDzialow[i].Length + Environment.NewLine);
                for (int j = 0; j < tablicaDzialow[i].Length; j++)
                {
                    if (tablicaDzialow[i][j] > najnowszy)
                    {
                        najnowszy = tablicaDzialow[i][j];
                        dzialNajnowszego = i;
                    }
                }

            }
            
            Console.Write("Najwiecej pracownikow ma dzial nr: " + najwiecejPracownikow + Environment.NewLine +
                          "Najnowszy pracownik o ID "+najnowszy+" jest w dziale "+dzialNajnowszego);
        }
    }
}