using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Classic
    {
        static void Main()
        {
            Item bulka = new Item("Bluka", "Описанная вкусная булка", 15);
            bulka.VivodZnach();

            Customer Lox1 = new Customer("Loshara", "Dom1");
            Lox1.VivodZnach();

            Item Xleb = new Item("Xleb", "Черствый хлеб", 5);
            Xleb.VivodZnach();

            Customer Lox2 = new Customer("Umnik", "Dom2");
            Lox2.VivodZnach();
        }
    }
}
