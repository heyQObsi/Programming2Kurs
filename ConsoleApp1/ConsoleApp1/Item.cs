using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    internal class Item
    {
        private readonly int _id;
        private string _name;
        private string _description;
        private double _cost;

        private string Name
        {
            get { return _name; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }
        private string Description
        {
            get { return _description; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Description");
                _description = value;
            }
        }
        private double Cost
        {
            get { return _cost; }
            set
            {
                if(value < 0 || value > 100000)
                    throw new ArgumentException($"Cost должен быть в диапозоне от 0 до 100.000");
                _cost = value;
            }
        }
        //public Item() {}
        public Item(string name, string description, int cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
            _id = IdGenerator.Schetchiki;
        }
        //public void VvodZnach(string name, string description, int cost)
        //{
        //    _name = name;
        //    _description = description;
        //    _cost = cost;
        //    _id = Schetchik.Schetchiki;
        //}
        public void VivodZnach()
        {
            Console.WriteLine(_id);
            Console.WriteLine(_name);
            Console.WriteLine(_description);
            Console.WriteLine(_cost);
        }
    }
}