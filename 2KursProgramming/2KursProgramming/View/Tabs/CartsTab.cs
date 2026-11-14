using _2KursProgramming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _2KursProgramming.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public Store _store = new Store();
        BindingList<Item> CartItems = new BindingList<Item>();
        BindingList<Customer> CartCustomers = new BindingList<Customer>();
        BindingList<Item> CurrentCustomer = new BindingList<Item>();

        public CartsTab()
        {
            InitializeComponent();
            CustomersCombobox.DataSource = CartCustomers;
            CartItemListbox.DataSource = CartItems;
            CartListbox.DataSource = CurrentCustomer;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> CartCustomersUpdater
        {
            get { return CartCustomers; }
            set
            {
                CartCustomers = value;
                CustomersCombobox.DataSource = CartCustomers;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Item> CartItemUpdater
        {
            get { return CartItems; }
            set
            {
                CartItems = value;
                CartItemListbox.DataSource = CartItems;
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CartItemListbox.SelectedIndex >= 0)
            {
                Item Ash = (Item)CartItemListbox.SelectedItem;
                int Length = PriceTxt.Text.Length;
                CurrentCustomer.Add(Ash);
                PriceTxt.Text = (double.Parse(PriceTxt.Text) + Ash.Cost).ToString() + ",0";
                if (Length < PriceTxt.Text.Length)
                {
                    PriceTxt.Location = new Point(PriceTxt.Location.X - (PriceTxt.Text.Length - Length) * 13, PriceTxt.Location.Y);
                }
                CartListbox.DataSource = CurrentCustomer;
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListbox.SelectedIndex >= 0)
            {
                Item Ash = (Item)CartListbox.SelectedItem;
                int Length = PriceTxt.Text.Length;
                PriceTxt.Text = (Math.Round(double.Parse(PriceTxt.Text) - Ash.Cost, 1)).ToString() + ",0";
                if (Length > PriceTxt.Text.Length)
                {
                    PriceTxt.Location = new Point(PriceTxt.Location.X + (Length - PriceTxt.Text.Length) * 13, PriceTxt.Location.Y);
                }
                CurrentCustomer.Remove(Ash);
                CartListbox.DataSource = CurrentCustomer;
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Clear();
            PriceTxt.Location = new Point(PriceTxt.Location.X + (PriceTxt.Text.Length - 4) * 13, PriceTxt.Location.Y);
            PriceTxt.Text = "0,00";
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {

        }
        public void RefreshData()
        {
            CustomersCombobox.DataSource = CartCustomers;
            CartItemListbox.DataSource = CartItems;
            CartListbox.DataSource = CurrentCustomer;
        }
    }
}