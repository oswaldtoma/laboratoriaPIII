using System;

namespace kolokwium_9._11
{
    public class CWarunekModulo
    {
        public void warunekModulo(in int[] value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                try
                {
                    if (value[i] % i +1 == 0)
                        Console.WriteLine("Liczba nr " + i + " spelnia warunek");
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Dzielenie przez zero dla "+i);
                }
            }
        }
    }
}