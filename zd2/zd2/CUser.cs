using System;
using System.Text;
using System.Xml.Schema;

namespace zd2
{
    public class CUser
    {
        public string Username { get; }
        public string Password { get; }
        public int toysAmount { get; set; }
        public int shoePairsAmount { get; set; }
        public int bulletsAmount { get; set; }


        public CUser(){}
        public CUser(string _u, string _p)
        {
            Username = _u;
            Password = _p;
        }

        public void produceAToy()
        {
            toysAmount++;
            Console.WriteLine("To juz " + toysAmount + " w tej sesji");
        }
        
        public void produceAShoePair()
        {
            shoePairsAmount++;
            Console.WriteLine("To juz " + shoePairsAmount + " w tej sesji");
        }
        
        public void produceABullet()
        {
            bulletsAmount++;
            Console.WriteLine("To juz " + bulletsAmount + " w tej sesji");
        }
    }
}