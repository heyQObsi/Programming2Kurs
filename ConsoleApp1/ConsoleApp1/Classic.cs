using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

            List<Item> xlebi = new List<Item>();

            Item bulka = new("Bluka", "Описанная вкусная булкf", 235);
            //bulka.VivodZnach();
            xlebi.Add(bulka);

            //Customer Lox1 = new Customer("Loshara", "Dom1");
            //Lox1.VivodZnach();
            //ProjectSerializer.Ser1alzing(Lox1);
            //var kak = JsonConvert.DeserializeObject(File.ReadAllText("C:\\Users\\heyQ\\Desktop\\Serial.json"));

            Item Xleb = new Item("Xleb", "Черствый хлеб", 5);
            //Xleb.VivodZnach();
            xlebi.Add(Xleb);
            ProjectSerializer.Ser1alzing(xlebi);

            //Item Pizza = new Item("Pizza", "Очень квадратная?.. Пицца", 9);
            //ProjectSerializer.Ser1alzing(Pizza);
            //List<Item> tak = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText("C:\\Users\\heyQ\\Desktop\\Serial.json"));
            //tak[2].VivodZnach();

            Customer Lox2 = new Customer("Umnik", "Dom2");
            Lox2.VivodZnach();

            Console.WriteLine(ItemFactory.VivodLines(lines));
            Console.WriteLine(CustomerFactory.CustGenerate(Name, Surname, Fathername, lines));
        }
    }
}
