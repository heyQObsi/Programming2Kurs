using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _2KursProgramming.Model
{
    public class Store
    {
        private BindingList<Item> _items = new();
        private BindingList<Customer> _customers = new();

        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public BindingList<Customer> Cutomers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public Store() { }
    }
}
