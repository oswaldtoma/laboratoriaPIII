using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;

namespace zajecia5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<DateTime> lista = new List<DateTime>();
            DateTime wynik = lista.Where(
                x => x.Year > 2000 && 
                x.Month == 11 && 
                x.AddDays(1).DayOfWeek == DayOfWeek.Monday).FirstOrDefault();
            DateTime data = default(DateTime);

        }
    }
}