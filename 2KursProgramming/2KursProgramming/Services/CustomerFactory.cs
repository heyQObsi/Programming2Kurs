using System;
using System.Collections.Generic;
using System.Text;

namespace _2KursProgramming.Services
{
    internal class CustomerFactory
    {
        public static string[] CustGenerate(string[] Name, string[] Surname, string[] Fathername, string[] Address)
        {
            Random rand = new Random();
            string RandName = Name[rand.Next(Name.Length)];
            string RandSurname = Surname[rand.Next(Surname.Length)];
            string RandFathername = Fathername[rand.Next(Fathername.Length)];
            string RandFullname = $"{RandName} {RandSurname} {RandFathername}";
            string RandAddress = Address[rand.Next(Address.Length)];
            return [RandFullname, RandAddress];
        }
    }
}
