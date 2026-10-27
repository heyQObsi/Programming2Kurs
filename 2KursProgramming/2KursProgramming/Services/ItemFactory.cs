using System;
using System.Collections.Generic;
using System.Text;

namespace _2KursProgramming.Services
{
    internal class ItemFactory
    {
        public static (string FactoryItemName, string FactoryInfo, double FactoryCost, Category category) RandomItem(string[] lines)
        {
            Random rand = new Random();
            int Rand1 = rand.Next(lines.Length);
            double Rand2 = rand.Next(100000);
            Category Rand3 = (Category)rand.Next(7);
            if (Rand1 % 2 == 0)
            {
                return (lines[Rand1], lines[Rand1 + 1], Rand2, Rand3);
            }
            else
            {
                return (lines[Rand1 - 1], lines[Rand1], Rand2, Rand3);
            }
        }
    }
}
