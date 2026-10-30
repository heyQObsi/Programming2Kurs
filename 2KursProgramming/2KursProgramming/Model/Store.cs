using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _2KursProgramming.Model
{
    public class Store
    {
        private BindingList<Item> _items = [];
        private BindingList<Customer> _cutomers = [];
        public BindingList<Item> Items { get { return _items; } set { _items = value; } }
        public BindingList<Customer> Cutomers { get { return _cutomers; } set { _cutomers = value; } }
        public Store() { }
    }
}
