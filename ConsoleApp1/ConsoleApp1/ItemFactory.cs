using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ItemFactory
    {
        public static string VivodLines(string[] lines)
        {
            Random rand = new Random();
            int Rand1 = rand.Next(lines.Length);
            int Rand2 = rand.Next(100000);
            if (Rand1%2 == 0)
            {
                return($"Имя: {lines[Rand1]} Инфо: {lines[Rand1 + 1]} Цена: {Rand2}");
            }
            else
            {
                return($"Имя: {lines[Rand1 - 1]} Инфо: {lines[Rand1]} Цена: {Rand2}");
            }
        }
    }
}
