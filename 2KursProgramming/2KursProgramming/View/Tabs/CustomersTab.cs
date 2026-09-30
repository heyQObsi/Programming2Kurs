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
    public partial class CustomersTab : UserControl
    {
        private string[] CustomerName = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Name.txt");
        private string[] CustomerSurname = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Surname.txt");
        private string[] CustomerFathername = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Fathername.txt");
        private string[] CustomerAddress = File.ReadAllLines("C:\\Users\\heyQ\\Desktop\\Новая папка (2)\\Address.txt");
        public CustomersTab()
        {
            InitializeComponent();
            CustomersListbox.DataSource = customers;
        }


        BindingList<Customer> customers = new BindingList<Customer>();
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddCustButton_Click(object sender, EventArgs e)
        {
            Customer template_customer = new Customer(FullNameTextbox.Text, AddressTextbox.Text);
            customers.Add(template_customer);
        }

        private void CustRemoveButton_Click(object sender, EventArgs e)
        {
            customers.RemoveAt(CustomersListbox.SelectedIndex);
        }

        private void RandCustButton_Click(object sender, EventArgs e)
        {
            string[] RandomCustomer = CustomerFactory.CustGenerate(CustomerName, CustomerSurname, CustomerFathername, CustomerAddress);
            Customer template_customer = new Customer(RandomCustomer[0], RandomCustomer[1]);
            customers.Add(template_customer);
        }
    }
}
