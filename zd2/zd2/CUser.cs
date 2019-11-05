using System;
using System.Text;
using System.Xml.Schema;

namespace zd2
{
    public class CUser
    {
        public string Username { get; }
        public string Password { get; }
        public int ItemsAmount { get; set; }

        public CUser(){}
        public CUser(string _u, string _p)
        {
            Username = _u;
            Password = _p;
        }

        public void produceAnItem()
        {
            ItemsAmount++;
            Console.WriteLine("To juz " + ItemsAmount + " w tej sesji");
        }
    }
}