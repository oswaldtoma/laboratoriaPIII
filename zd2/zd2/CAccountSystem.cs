using System;
using System.Configuration;
using Microsoft.Win32;

namespace zd2
{
    public static class CAccountSystem
    {
        private static CUser[] users = {new CUser("john", "passjohn"), new CUser("peter", "passpeter"), new CUser("roger", "passroger") };
        
        public static bool loginProcedure(ref CUser userPtr)
        {
            Console.Write("Podaj login: ");
            string login = Console.ReadLine();
            for (int i = 0; i < users.Length; i++)
            {
                if (login == users[i].Username)
                {
                    userPtr = users[i];
                    return passwordVerification(i);
                }
            }
            Console.WriteLine("Uzytkownik nieznaleziony.");
            return false;
        }

        private static bool passwordVerification(int id)
        {
            Console.WriteLine("Uzytkownik: " + users[id].Username);
            Console.Write("Podaj haslo: ");
            string pass = Console.ReadLine();
            if (pass == users[id].Password)
            {
                Console.WriteLine("Haslo poprawne.");
                return true;
            }
            Console.WriteLine("Bledne haslo!");
            return false;
        }
    }
}