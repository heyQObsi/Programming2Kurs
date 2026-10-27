using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using _2KursProgramming.Model;

namespace _2KursProgramming.Services
{
    internal class ProjectSerializer
    {
        public static void SerialzingItem(Item sut)
        {
            string oldOne = File.ReadAllText("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\ItemJSON.json");
            List<Item> itemss = JsonConvert.DeserializeObject<List<Item>>(oldOne) ?? [];
            itemss.Add(sut);
            File.WriteAllText("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\ItemJSON.json", JsonConvert.SerializeObject(itemss));
        }
        public static void SerialzingCustomer(Customer sut)
        {
            string oldOne = File.ReadAllText("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\CustomerJSON.json");
            List<Customer> itemss = JsonConvert.DeserializeObject<List<Customer>>(oldOne) ?? [];
            itemss.Add(sut);
            File.WriteAllText("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\CustomerJSON.json", JsonConvert.SerializeObject(itemss));
        }
    }
}
