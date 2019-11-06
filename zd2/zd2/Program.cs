using System;
using System.Net;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Win32;

namespace zd2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CUser user = new CUser();

            void logoutAndSaveData()
            {
                if (!Directory.Exists(user.Username))
                    Directory.CreateDirectory(user.Username);
                    
                string date = DateTime.Today.Date.ToString().Substring(0,10);

                string data = user.Username + " " + DateTime.Now.ToString().Substring(11, 5) + Environment.NewLine +
                              "Zabawki: " + user.toysAmount + Environment.NewLine +
                              "Pary butow" + user.shoePairsAmount + Environment.NewLine +
                              "Naboje" + user.bulletsAmount + Environment.NewLine + Environment.NewLine;
                
                string path = user.Username + "\\" + date + ".txt";
                
                if(!File.Exists(path))
                File.AppendAllText(path, data);
                Console.WriteLine("Do zobaczenia!");
            }
            
            if (CAccountSystem.loginProcedure(ref user))
            {
                Console.WriteLine("Witaj, " + user.Username);
                string userInput;
                do
                {
                    Console.Write("(1). Wyprodukuj zabawke \n" +
                                  "(2). Wyprodukuj pare butow \n" +
                                  "(3). Wyprodukuj naboj \n" +
                                  "(4). Sprawdz ilosc przedmiotow wyprodukowanych w tej sesji \n" +
                                  "(x). Wyloguj \n");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            user.toysAmount++;
                            Console.WriteLine("To juz " + user.toysAmount + " zabawka w tej sesji");
                            break;
                        case "2":
                            user.shoePairsAmount++;
                            Console.WriteLine("To juz " + user.shoePairsAmount + " para butow w tej sesji");
                            break;
                        case "3":
                            user.bulletsAmount++;
                            Console.WriteLine("To juz " + user.bulletsAmount + " naboj w tej sesji");
                            break;
                        case "4":
                            Console.Write("Ilosc wyprodukowanych przed Ciebie przedmiotow wynosi: \n" + 
                                              "Zabawki: " + user.toysAmount + "\n" + 
                                              "Pary butow: " + user.shoePairsAmount + "\n" +
                                              "Naboje: " + user.bulletsAmount + "\n");
                            break;
                        case "x":
                            logoutAndSaveData();
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