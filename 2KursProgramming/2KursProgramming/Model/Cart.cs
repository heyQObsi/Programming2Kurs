using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _2KursProgramming.Model
{
    public class Cart
    {
        private int _amount = 0;
        private List<Item> _cartitems = [];
        public double Amount
        {
            get
            {
                double x = 0;
                if (_cartitems != null)
                {
                    foreach (Item item in _cartitems)
                    {
                        x += item.Cost;
                    }
                }
                return x;
            }
        }
        public List<Item> CartItems
        {
            get { return _cartitems; }
            set
            {
                _cartitems = value;
            }
        }
    }
}
