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
            IdItemTextbox.Text = IdGenerator.ItemGetCurrentId().ToString();
            CategoryCombobox.DataSource = Enum.GetValues(typeof(Category));
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
            Category category = (Category)CategoryCombobox.SelectedItem;
            Item product = new Item(NameTextbox.Text, DescriptionTextbox.Text, int.Parse(CostTextbox.Text), category);
            items.Add(product);
            IdItemTextbox.Text = IdGenerator.ItemGetCurrentId().ToString();
            
        }

        private void ItemRemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListbox.Items.Count != 0)
            {
                items.RemoveAt(ItemsListbox.SelectedIndex);
            }
        }

        private void ItemsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item? ItemTub = ItemsListbox.SelectedItem as Item;
            IdItemTextbox.Text = ItemTub.Id.ToString();
            NameTextbox.Text = ItemTub.Name;
            DescriptionTextbox.Text = ItemTub.Info;
            CostTextbox.Text = ItemTub.Cost.ToString();
            CategoryCombobox.Text = ItemTub.Category.ToString();
        }

        private void RandomItemButton_Click(object sender, EventArgs e)
        {
            ValueTuple<string, string, double, Category> FactoryTuple = ItemFactory.RandomItem(FactoryItem);
            Item product = new Item(FactoryTuple.Item1, FactoryTuple.Item2, FactoryTuple.Item3, FactoryTuple.Item4);
            items.Add(product);
            IdItemTextbox.Text = IdGenerator.ItemGetCurrentId().ToString();
        }

        private void CostTextbox_TextChanged(object sender, EventArgs e)
        {
            if ((double.TryParse(CostTextbox.Text, out double Cost) && Cost < 100000 && Cost > 0) || CostTextbox.Text == "")
            {
                CostTextbox.BackColor = Color.White;
            }
            else
            {
                CostTextbox.BackColor = Color.Red;
                ErrorProvider errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(CostTextbox, "Not");
            }
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextbox.Text.Length > 200)
            {
                NameTextbox.BackColor = Color.Red;
            }
            else
            {
                NameTextbox.BackColor = Color.White;
            }
        }

        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextbox.Text.Length > 1000)
            {
                DescriptionTextbox.BackColor = Color.Red;
            }
            else
            {
                DescriptionTextbox.BackColor = Color.White;
            }
        }

        private void CategoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
