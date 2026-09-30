using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Classic
    {
        static void Main()
        {
            string[] lines = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\ItemInfo.txt");
            string[] Name = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Name.txt");
            string[] Surname = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Surname.txt");
            string[] Fathername = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Fathername.txt");

            Item bulka = new Item("Bluka", "Описанная вкусная булка", 15);
            bulka.VivodZnach();

            Customer Lox1 = new Customer("Loshara", "Dom1");
            Lox1.VivodZnach();

            Item Xleb = new Item("Xleb", "Черствый хлеб", 5);
            Xleb.VivodZnach();

            Customer Lox2 = new Customer("Umnik", "Dom2");
            Lox2.VivodZnach();

            Console.WriteLine(ItemFactory.VivodLines(lines));
            Console.WriteLine(CustomerFactory.CustGenerate(Name, Surname, Fathername, lines));
        }
    }
}
