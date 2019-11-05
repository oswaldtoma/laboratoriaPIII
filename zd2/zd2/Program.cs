using System;

namespace zd2
{
    public class Program
    {
        private static void logout()
        {
            //dodac zapis do pliku
            Console.WriteLine("Do zobaczenia!");
        }
        public static void Main(string[] args)
        {
            CUser user = new CUser();
            if (CAccountSystem.loginProcedure(ref user))
            {
                Console.WriteLine("Witaj, " + user.Username);
                string userInput;
                do
                {
                    Console.Write("(1). Wyprodukuj przedmiot \n" +
                                  "(2). Sprawdz ilosc przedmiotow \n" +
                                  "(x). Wyloguj \n");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            user.produceAnItem();
                            break;
                        case "2":
                            Console.WriteLine("Ilosc wyprodukowanych przed Ciebie przedmiotow wynosi: " + user.ItemsAmount);
                            break;
                        case "x":
                            logout();
                            break;
                        default:
                            Console.WriteLine("Nie ma takiej opcji...");
                            break;
                    }
                } while (userInput != "x");
            }
        }
    }
}