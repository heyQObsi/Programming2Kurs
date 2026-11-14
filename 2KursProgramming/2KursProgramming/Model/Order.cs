using System;
using System.Collections.Generic;
using System.Text;

namespace _2KursProgramming.Model
{
    public class Order
    {
        readonly private double _id = 0;
        readonly private string _data = "";
        private string _address = "";
        private List<Item> _itemlist = [];
        private int _totalycost = 0;
        public string Address { get { return _address; } }
        public List<Item> ItemList { get { return _itemlist; } }
        public int TotalyCost { get { return _totalycost; } }

    }
}
