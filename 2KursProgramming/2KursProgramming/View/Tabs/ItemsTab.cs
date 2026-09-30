using _2KursProgramming.Model;
using _2KursProgramming.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2KursProgramming.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private string[] FactoryItem = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\ItemInfo.txt");
        public ItemsTab()
        {
            InitializeComponent();
            ItemsListbox.DataSource = items;
        }
        BindingList<Item> items = new BindingList<Item>();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            Item product = new Item(NameTextbox.Text, DescriptionTextbox.Text, int.Parse(CostTextbox.Text));
            items.Add(product);
        }

        private void ItemRemoveButton_Click(object sender, EventArgs e)
        {
            items.RemoveAt(ItemsListbox.SelectedIndex);
        }

        private void ItemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RandomItemButton_Click(object sender, EventArgs e)
        {
            ValueTuple<string, string, double> FactoryTuple = ItemFactory.RandomItem(FactoryItem);
            Item product = new Item(FactoryTuple.Item1, FactoryTuple.Item2, FactoryTuple.Item3);
            items.Add(product);
        }
    }
}
