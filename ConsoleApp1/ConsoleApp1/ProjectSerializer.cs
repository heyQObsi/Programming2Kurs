using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    internal class ProjectSerializer
    {
        public static void Ser1alzing(List<Item> sut)
        {
            string oldOne = File.ReadAllText("C:\\Users\\heyQ\\Desktop\\Serial.json");
            List<Item> itemss = JsonConvert.DeserializeObject<List<Item>>(oldOne) ?? [];
            List<Item> result = itemss.Concat(sut).ToList();
            File.WriteAllText("C:\\Users\\heyQ\\Desktop\\Serial.json", JsonConvert.SerializeObject(result));
        }
        public static void Ser1alzing(Item sut)
        {
            string oldOne = File.ReadAllText("C:\\Users\\heyQ\\Desktop\\Serial.json");
            List<Item> itemss = JsonConvert.DeserializeObject<List<Item>>(oldOne) ?? [];
            itemss.Add(sut);
            File.WriteAllText("C:\\Users\\heyQ\\Desktop\\Serial.json", JsonConvert.SerializeObject(itemss));
        }
    }
}
