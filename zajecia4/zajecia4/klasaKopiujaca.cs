using System;

namespace zajecia4
{
    public class klasaKopiujaca
    {
        public static void skopiujTablice(int[][] poszarpana, int[][] newPoszarpana, ref bool stan)
        {
            stan = true;
            for (int i = 0; i < poszarpana.Length; i++)
            {
                newPoszarpana[i] = new int[poszarpana[i].Length];
                for (int j = 0; j < poszarpana[i].Length; j++)
                {
                    newPoszarpana[i][j] = poszarpana[i][j];
                    Console.Write(poszarpana[i][j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            newPoszarpana[1][0] = 0;

            for (int i = 0; i < poszarpana.Length; i++)
            {
                for (int j = 0; j < poszarpana[i].Length; j++)
                {
                    Console.Write(newPoszarpana[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}