using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CustomerFactory
    {
        public static string CustGenerate(string[] Name, string[] Surname, string[] Fathername, string[] Address)
        {
            Random rand = new Random();
            string Rand1 = Name[rand.Next(Name.Length)];
            string Rand2 = Surname[rand.Next(Surname.Length)];
            string Rand3 = Fathername[rand.Next(Fathername.Length)];
            string Rand4 = Address[rand.Next(Address.Length)];
            return ($"Полное имя: {Rand1} {Rand2} {Rand3}, Адрес: {Rand4}");
        }
    }
}
